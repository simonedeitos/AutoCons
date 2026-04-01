using MailKit;
using MailKit.Net.Imap;
using MailKit.Net.Smtp;
using MailKit.Search;
using MimeKit;

namespace AutoCons.Services
{
    public class EmailService
    {
        private readonly string _smtpServer;
        private readonly int _smtpPort;
        private readonly bool _smtpUseSsl;
        private readonly string _imapServer;
        private readonly int _imapPort;
        private readonly bool _imapUseSsl;
        private readonly string _username;
        private readonly string _password;

        public EmailService(
            string smtpServer, int smtpPort, bool smtpUseSsl,
            string imapServer, int imapPort, bool imapUseSsl,
            string username, string password)
        {
            _smtpServer = smtpServer;
            _smtpPort = smtpPort;
            _smtpUseSsl = smtpUseSsl;
            _imapServer = imapServer;
            _imapPort = imapPort;
            _imapUseSsl = imapUseSsl;
            _username = username;
            _password = password;
        }

        public async Task SendAndSaveAsync(MimeMessage message)
        {
            // Send via SMTP
            using (var smtp = new SmtpClient())
            {
                await smtp.ConnectAsync(_smtpServer, _smtpPort,
                    _smtpUseSsl ? MailKit.Security.SecureSocketOptions.StartTls : MailKit.Security.SecureSocketOptions.None);
                await smtp.AuthenticateAsync(_username, _password);
                await smtp.SendAsync(message);
                await smtp.DisconnectAsync(true);
            }

            // Save to Sent folder via IMAP
            if (!string.IsNullOrWhiteSpace(_imapServer))
            {
                await SaveToSentAsync(message);
            }
        }

        private async Task SaveToSentAsync(MimeMessage message)
        {
            using var imap = new ImapClient();
            await imap.ConnectAsync(_imapServer, _imapPort,
                _imapUseSsl ? MailKit.Security.SecureSocketOptions.SslOnConnect : MailKit.Security.SecureSocketOptions.None);
            await imap.AuthenticateAsync(_username, _password);

            // Find Sent folder
            var sentFolder = await FindSentFolderAsync(imap);
            if (sentFolder != null)
            {
                await sentFolder.OpenAsync(FolderAccess.ReadWrite);
                await sentFolder.AppendAsync(message, MessageFlags.Seen);
            }

            await imap.DisconnectAsync(true);
        }

        public async Task<IMailFolder?> FindSentFolderAsync(ImapClient imap)
        {
            // Search by special-use attribute
            var personal = imap.GetFolder(imap.PersonalNamespaces[0]);
            await personal.OpenAsync(FolderAccess.ReadOnly);

            foreach (var folder in personal.GetSubfolders(false))
            {
                if (folder.Attributes.HasFlag(FolderAttributes.Sent))
                    return folder;
            }

            // Fallback: look by name
            var sentNames = new[] { "Sent", "Sent Items", "Posta inviata", "Enviados", "Envoyés" };
            foreach (var folder in personal.GetSubfolders(false))
            {
                if (sentNames.Any(n => string.Equals(n, folder.Name, StringComparison.OrdinalIgnoreCase)))
                    return folder;
            }

            return null;
        }

        public async Task<List<MimeMessage>> FetchUnprocessedMessagesAsync(
            string senderFilter,
            Func<string, bool> isProcessed)
        {
            var result = new List<MimeMessage>();

            using var imap = new ImapClient();
            await imap.ConnectAsync(_imapServer, _imapPort,
                _imapUseSsl ? MailKit.Security.SecureSocketOptions.SslOnConnect : MailKit.Security.SecureSocketOptions.None);
            await imap.AuthenticateAsync(_username, _password);

            await imap.Inbox.OpenAsync(FolderAccess.ReadWrite);

            // Search for messages from the configured sender
            var query = SearchQuery.FromContains(senderFilter);
            var uids = await imap.Inbox.SearchAsync(query);

            foreach (var uid in uids)
            {
                var msg = await imap.Inbox.GetMessageAsync(uid);
                var messageId = msg.MessageId ?? string.Empty;

                if (!isProcessed(messageId))
                    result.Add(msg);
            }

            await imap.DisconnectAsync(true);
            return result;
        }

        public async Task MarkAsAnsweredAsync(MimeMessage original)
        {
            if (string.IsNullOrWhiteSpace(original.MessageId)) return;

            using var imap = new ImapClient();
            await imap.ConnectAsync(_imapServer, _imapPort,
                _imapUseSsl ? MailKit.Security.SecureSocketOptions.SslOnConnect : MailKit.Security.SecureSocketOptions.None);
            await imap.AuthenticateAsync(_username, _password);

            await imap.Inbox.OpenAsync(FolderAccess.ReadWrite);

            var query = SearchQuery.HeaderContains("Message-Id", original.MessageId);
            var uids = await imap.Inbox.SearchAsync(query);

            if (uids.Count > 0)
                await imap.Inbox.AddFlagsAsync(uids, MessageFlags.Answered, true);

            await imap.DisconnectAsync(true);
        }

        public async Task SendReplyAndSaveAsync(
            MimeMessage original, MimeMessage reply,
            string sentImapServer, int sentImapPort, bool sentImapSsl)
        {
            // Send via SMTP
            using (var smtp = new SmtpClient())
            {
                await smtp.ConnectAsync(_smtpServer, _smtpPort,
                    _smtpUseSsl ? MailKit.Security.SecureSocketOptions.StartTls : MailKit.Security.SecureSocketOptions.None);
                await smtp.AuthenticateAsync(_username, _password);
                await smtp.SendAsync(reply);
                await smtp.DisconnectAsync(true);
            }

            // Save to Sent
            if (!string.IsNullOrWhiteSpace(sentImapServer))
            {
                using var imap = new ImapClient();
                await imap.ConnectAsync(sentImapServer, sentImapPort,
                    sentImapSsl ? MailKit.Security.SecureSocketOptions.SslOnConnect : MailKit.Security.SecureSocketOptions.None);
                await imap.AuthenticateAsync(_username, _password);

                var sentFolder = await FindSentFolderAsync(imap);
                if (sentFolder != null)
                {
                    await sentFolder.OpenAsync(FolderAccess.ReadWrite);
                    await sentFolder.AppendAsync(reply, MessageFlags.Seen);
                }

                await imap.DisconnectAsync(true);
            }
        }
    }
}
