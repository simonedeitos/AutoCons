using AutoCons.Helpers;
using AutoCons.Models;
using MimeKit;

namespace AutoCons.Services
{
    public class SenderService
    {
        private const string SentNumbersSubKey = "Sender\\SentNumbers";

        private readonly SenderConfig _config;

        public SenderService(SenderConfig config)
        {
            _config = config;
        }

        public async Task RunAsync()
        {
            LogService.Info("SenderService: avvio operazione");

            // Load and normalize phone numbers from file
            var allNumbers = LoadAndNormalizeNumbers();
            if (allNumbers.Count == 0)
            {
                LogService.Warn("SenderService: nessun numero trovato nel file");
                return;
            }

            // Load sent numbers from Registry
            var sentNumbers = RegistryHelper.LoadAllValues(SentNumbersSubKey);
            var sentSet = new HashSet<string>(sentNumbers.Keys);

            // Filter unsent
            var unsent = allNumbers.Where(n => !sentSet.Contains(n)).ToList();

            // If all sent, reset and restart
            if (unsent.Count == 0)
            {
                LogService.Info("SenderService: tutti i numeri inviati, reset storico");
                RegistryHelper.ClearSubKey(SentNumbersSubKey);
                unsent = new List<string>(allNumbers);
            }

            // Select random N numbers
            int count = Math.Min(_config.NumbersPerEmail, unsent.Count);
            var rng = new Random();
            var selected = unsent.OrderBy(_ => rng.Next()).Take(count).ToList();

            LogService.Info($"SenderService: selezionati {selected.Count} numeri da inviare");

            // Build email
            var message = BuildMessage(selected);

            // Send
            var emailService = new EmailService(
                _config.SmtpServer, _config.SmtpPort, _config.SmtpUseSsl,
                _config.ImapServer, _config.ImapPort, _config.ImapUseSsl,
                _config.Username, _config.Password);

            await emailService.SendAndSaveAsync(message);
            LogService.Info("SenderService: email inviata con successo");

            // Register sent numbers in Registry
            var timestamp = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            foreach (var number in selected)
                RegistryHelper.SaveValue(SentNumbersSubKey, number, timestamp);

            LogService.Info($"SenderService: {selected.Count} numeri registrati nel Registry");
        }

        private List<string> LoadAndNormalizeNumbers()
        {
            if (!File.Exists(_config.NumbersFilePath))
            {
                LogService.Error($"SenderService: file numeri non trovato: {_config.NumbersFilePath}");
                return new List<string>();
            }

            var rawNumbers = CsvSmartReader.ReadPhoneNumbers(_config.NumbersFilePath);
            var normalized = rawNumbers
                .Select(PhoneNormalizer.Normalize)
                .Where(n => !string.IsNullOrWhiteSpace(n))
                .Distinct()
                .ToList();

            LogService.Info($"SenderService: {normalized.Count} numeri unici caricati dal file");
            return normalized;
        }

        private MimeMessage BuildMessage(List<string> numbers)
        {
            var message = new MimeMessage();
            message.From.Add(new MailboxAddress(_config.SenderDisplayName, _config.Username));

            foreach (var recipient in _config.Recipients.Split(';', StringSplitOptions.RemoveEmptyEntries))
                message.To.Add(MailboxAddress.Parse(recipient.Trim()));

            message.Subject = _config.Subject;

            // Build number list: each number on its own line with ; suffix
            var numberList = string.Join(Environment.NewLine, numbers.Select(n => $"{n};"));
            var body = _config.BodyTemplate.Replace("<numbers>", numberList);

            // Compute HMAC signature on body
            var signature = SignatureService.Sign(body, _config.SharedHmacKey);

            message.Headers.Add("X-AutoCons-Signature", signature);

            message.Body = new TextPart("plain") { Text = body };

            return message;
        }
    }
}
