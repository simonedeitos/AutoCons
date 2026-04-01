using System.Text.Json.Serialization;

namespace AutoCons.Models
{
    public class ReceiverConfig
    {
        // IMAP for receiving
        public string ImapServer { get; set; } = string.Empty;
        public int ImapPort { get; set; } = 993;
        public bool ImapUseSsl { get; set; } = true;
        public string ImapUsername { get; set; } = string.Empty;

        [JsonIgnore]
        public string ImapPassword { get; set; } = string.Empty;

        public string ImapPasswordEncrypted { get; set; } = string.Empty;

        // SMTP for reply
        public string SmtpServer { get; set; } = string.Empty;
        public int SmtpPort { get; set; } = 587;
        public bool SmtpUseSsl { get; set; } = true;
        public string SmtpUsername { get; set; } = string.Empty;

        [JsonIgnore]
        public string SmtpPassword { get; set; } = string.Empty;

        public string SmtpPasswordEncrypted { get; set; } = string.Empty;

        public string SenderDisplayName { get; set; } = string.Empty;

        // IMAP for saving sent replies
        public string SentImapServer { get; set; } = string.Empty;
        public int SentImapPort { get; set; } = 993;
        public bool SentImapUseSsl { get; set; } = true;

        // Sender filter
        public string MonitoredSenderEmail { get; set; } = string.Empty;

        // Schedule
        public TimeSpan CheckTime { get; set; } = new TimeSpan(18, 15, 0);

        // CSV
        public string CsvFilePath { get; set; } = string.Empty;
        public string PhoneColumnName { get; set; } = string.Empty;

        public string SharedHmacKey { get; set; } = "AutoCons2026!VerificaConsensi";

        public string ReplyTemplate { get; set; } =
            "Gentile mittente,\n\nIn riscontro alla Sua richiesta, in allegato troverà il file CSV con i numeri verificati.\n\n<notfound>Si precisa inoltre che dei numeri verificati, i seguenti: {numbers} non risultano essere numeri in nostro possesso.</notfound>\n\nCordiali saluti.";
    }
}
