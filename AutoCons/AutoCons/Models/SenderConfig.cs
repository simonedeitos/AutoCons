using System.Text.Json.Serialization;

namespace AutoCons.Models
{
    public class SenderConfig
    {
        public string NumbersFilePath { get; set; } = string.Empty;

        // Schedule: days 1-28 flagged
        public List<int> ScheduledDays { get; set; } = new();

        public TimeSpan MinTime { get; set; } = new TimeSpan(8, 0, 0);
        public TimeSpan MaxTime { get; set; } = new TimeSpan(17, 0, 0);

        public int NumbersPerEmail { get; set; } = 10;

        // SMTP
        public string SmtpServer { get; set; } = string.Empty;
        public int SmtpPort { get; set; } = 587;
        public bool SmtpUseSsl { get; set; } = true;

        // IMAP (for saving sent)
        public string ImapServer { get; set; } = string.Empty;
        public int ImapPort { get; set; } = 993;
        public bool ImapUseSsl { get; set; } = true;

        public string Username { get; set; } = string.Empty;

        [JsonIgnore]
        public string Password { get; set; } = string.Empty;

        // Encrypted password stored in JSON
        public string PasswordEncrypted { get; set; } = string.Empty;

        public string SenderDisplayName { get; set; } = string.Empty;
        public string Recipients { get; set; } = string.Empty;
        public string Subject { get; set; } = string.Empty;
        public string BodyTemplate { get; set; } = string.Empty;

        public string SharedHmacKey { get; set; } = "AutoCons2026!VerificaConsensi";
    }
}
