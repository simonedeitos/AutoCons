using System.Data;
using System.Text;
using System.Text.RegularExpressions;
using AutoCons.Helpers;
using AutoCons.Models;
using MimeKit;

namespace AutoCons.Services
{
    public class ReceiverService
    {
        private const string ProcessedEmailsSubKey = "Receiver\\ProcessedEmails";
        private const int DelayBetweenEmailsMs = 5 * 60 * 1000; // 5 minutes

        private readonly ReceiverConfig _config;

        public ReceiverService(ReceiverConfig config)
        {
            _config = config;
        }

        public async Task RunAsync()
        {
            LogService.Info("ReceiverService: avvio operazione");

            var emailService = new EmailService(
                _config.SmtpServer, _config.SmtpPort, _config.SmtpUseSsl,
                _config.ImapServer, _config.ImapPort, _config.ImapUseSsl,
                _config.ImapUsername, _config.ImapPassword);

            // Fetch unprocessed messages
            var messages = await emailService.FetchUnprocessedMessagesAsync(
                _config.MonitoredSenderEmail,
                msgId => RegistryHelper.Exists(ProcessedEmailsSubKey, msgId));

            LogService.Info($"ReceiverService: {messages.Count} email da elaborare");

            for (int i = 0; i < messages.Count; i++)
            {
                var msg = messages[i];
                try
                {
                    await ProcessMessageAsync(msg, emailService);

                    // Delay between messages
                    if (i < messages.Count - 1)
                    {
                        LogService.Info($"ReceiverService: attesa 5 minuti prima della prossima elaborazione");
                        await Task.Delay(DelayBetweenEmailsMs);
                    }
                }
                catch (Exception ex)
                {
                    LogService.Error($"ReceiverService: errore elaborazione email '{msg.Subject}'", ex);
                }
            }

            LogService.Info("ReceiverService: operazione completata");
        }

        private async Task ProcessMessageAsync(MimeMessage original, EmailService emailService)
        {
            LogService.Info($"ReceiverService: elaborazione email '{original.Subject}' da '{original.From}'");

            // Verify HMAC signature
            var body = GetTextBody(original);
            var signature = original.Headers["X-AutoCons-Signature"] ?? string.Empty;

            if (!SignatureService.Verify(body, signature, _config.SharedHmacKey))
            {
                LogService.Warn($"ReceiverService: firma HMAC non valida per email '{original.Subject}', ignorata");
                return;
            }

            // Parse phone numbers from email body
            var emailNumbers = ExtractPhoneNumbers(body);
            LogService.Info($"ReceiverService: trovati {emailNumbers.Count} numeri nell'email");

            // Load CSV
            if (!File.Exists(_config.CsvFilePath))
            {
                LogService.Error($"ReceiverService: file CSV non trovato: {_config.CsvFilePath}");
                return;
            }

            var (csvTable, _, _) = CsvSmartReader.ReadWithMeta(_config.CsvFilePath);

            // Find phone column index
            int phoneColIndex = FindPhoneColumnIndex(csvTable);
            if (phoneColIndex < 0)
            {
                LogService.Error($"ReceiverService: colonna '{_config.PhoneColumnName}' non trovata nel CSV");
                return;
            }

            // Search numbers in CSV
            var found = new List<DataRow>();
            var notFound = new List<string>();

            foreach (var number in emailNumbers)
            {
                bool foundInCsv = false;
                foreach (DataRow row in csvTable.Rows)
                {
                    var cellValue = row[phoneColIndex]?.ToString() ?? string.Empty;
                    var normalizedCell = PhoneNormalizer.Normalize(cellValue);
                    if (normalizedCell == number)
                    {
                        found.Add(row);
                        foundInCsv = true;
                    }
                }
                if (!foundInCsv)
                    notFound.Add(number);
            }

            LogService.Info($"ReceiverService: trovati={found.Count}, non trovati={notFound.Count}");

            // Build reply
            var reply = BuildReply(original, csvTable, found, notFound);

            // Send reply
            await emailService.SendReplyAndSaveAsync(
                original, reply,
                _config.SentImapServer, _config.SentImapPort, _config.SentImapUseSsl);

            // Mark as answered
            await emailService.MarkAsAnsweredAsync(original);

            // Register in Registry
            var messageId = original.MessageId ?? Guid.NewGuid().ToString();
            RegistryHelper.SaveValue(ProcessedEmailsSubKey, messageId,
                DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));

            LogService.Info($"ReceiverService: email elaborata e risposta inviata");
        }

        private static string GetTextBody(MimeMessage message)
        {
            return message.TextBody ?? message.HtmlBody ?? string.Empty;
        }

        private static List<string> ExtractPhoneNumbers(string body)
        {
            var numbers = new List<string>();
            // Pattern: line containing a number followed by semicolon
            var pattern = new Regex(@"^[\s]*(\+?[\d\s\-\.\(\)]{7,20});?\s*$", RegexOptions.Multiline);
            foreach (Match match in pattern.Matches(body))
            {
                var raw = match.Groups[1].Value.Trim();
                var normalized = PhoneNormalizer.Normalize(raw);
                if (!string.IsNullOrWhiteSpace(normalized))
                    numbers.Add(normalized);
            }
            return numbers.Distinct().ToList();
        }

        private int FindPhoneColumnIndex(DataTable table)
        {
            for (int i = 0; i < table.Columns.Count; i++)
            {
                if (string.Equals(table.Columns[i].ColumnName, _config.PhoneColumnName,
                    StringComparison.OrdinalIgnoreCase))
                    return i;
            }
            return -1;
        }

        private MimeMessage BuildReply(
            MimeMessage original,
            DataTable csvTable,
            List<DataRow> foundRows,
            List<string> notFound)
        {
            var reply = new MimeMessage();

            // Set From
            reply.From.Add(new MailboxAddress(_config.SenderDisplayName, _config.SmtpUsername));

            // Set To: reply to the sender of the original message
            reply.To.AddRange(original.From);

            // Set Subject: Re: ...
            reply.Subject = (original.Subject ?? string.Empty).StartsWith("Re:", StringComparison.OrdinalIgnoreCase)
                ? original.Subject ?? string.Empty
                : $"Re: {original.Subject ?? string.Empty}";

            // Set threading headers
            if (!string.IsNullOrEmpty(original.MessageId))
            {
                reply.InReplyTo = original.MessageId;
                reply.References.AddRange(original.References);
                reply.References.Add(original.MessageId);
            }

            // Build reply body
            string notFoundStr = notFound.Count > 0
                ? string.Join(", ", notFound)
                : string.Empty;

            string replyBody = _config.ReplyTemplate;
            if (notFound.Count == 0)
            {
                // Remove the <notfound> placeholder line entirely
                replyBody = Regex.Replace(replyBody,
                    @"[^\n]*<notfound>[^\n]*\n?", string.Empty);
            }
            else
            {
                replyBody = replyBody.Replace("<notfound>", notFoundStr);
            }

            // Build CSV attachment from found rows
            var builder = new BodyBuilder();
            builder.TextBody = replyBody;

            if (foundRows.Count > 0)
            {
                var csvBytes = BuildCsvBytes(csvTable, foundRows);
                builder.Attachments.Add("risultati.csv", csvBytes,
                    ContentType.Parse("text/csv"));
            }

            // HMAC signature on reply body
            var sig = SignatureService.Sign(replyBody, _config.SharedHmacKey);
            reply.Headers.Add("X-AutoCons-Signature", sig);

            reply.Body = builder.ToMessageBody();
            return reply;
        }

        private static byte[] BuildCsvBytes(DataTable table, List<DataRow> rows)
        {
            var sb = new StringBuilder();

            // Header
            var headers = table.Columns.Cast<DataColumn>()
                .Select(c => $"\"{c.ColumnName.Replace("\"", "\"\"")}\"");
            sb.AppendLine(string.Join(";", headers));

            // Rows
            foreach (var row in rows)
            {
                var cells = table.Columns.Cast<DataColumn>()
                    .Select(c => $"\"{(row[c]?.ToString() ?? string.Empty).Replace("\"", "\"\"")}\"");
                sb.AppendLine(string.Join(";", cells));
            }

            return Encoding.UTF8.GetBytes(sb.ToString());
        }
    }
}
