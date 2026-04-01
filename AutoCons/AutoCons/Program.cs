using AutoCons.Helpers;
using AutoCons.Models;
using AutoCons.Services;

namespace AutoCons
{
    internal static class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            ApplicationConfiguration.Initialize();

            if (args.Length > 0)
            {
                // CLI / silent mode
                RunSilentMode(args[0]);
                return;
            }

            // GUI mode
            Application.Run(new MainForm());
        }

        private static void RunSilentMode(string arg)
        {
            try
            {
                LogService.Info($"Program: avvio modalità silenziosa con argomento '{arg}'");

                if (arg == "--run-sender")
                {
                    var config = LoadSenderConfig();
                    if (config == null)
                    {
                        LogService.Error("Program: configurazione Sender non trovata");
                        return;
                    }
                    var service = new SenderService(config);
                    service.RunAsync().GetAwaiter().GetResult();
                }
                else if (arg == "--run-receiver")
                {
                    var config = LoadReceiverConfig();
                    if (config == null)
                    {
                        LogService.Error("Program: configurazione Receiver non trovata");
                        return;
                    }
                    var service = new ReceiverService(config);
                    service.RunAsync().GetAwaiter().GetResult();
                }
                else
                {
                    LogService.Warn($"Program: argomento sconosciuto '{arg}'");
                }
            }
            catch (Exception ex)
            {
                LogService.Error("Program: errore in modalità silenziosa", ex);
            }
        }

        private static SenderConfig? LoadSenderConfig()
        {
            var path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "config_sender.json");
            if (!File.Exists(path)) return null;

            var json = File.ReadAllText(path);
            var config = System.Text.Json.JsonSerializer.Deserialize<SenderConfig>(json);
            if (config != null && !string.IsNullOrEmpty(config.PasswordEncrypted))
                config.Password = CryptoHelper.Decrypt(config.PasswordEncrypted);

            return config;
        }

        private static ReceiverConfig? LoadReceiverConfig()
        {
            var path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "config_receiver.json");
            if (!File.Exists(path)) return null;

            var json = File.ReadAllText(path);
            var config = System.Text.Json.JsonSerializer.Deserialize<ReceiverConfig>(json);
            if (config != null)
            {
                if (!string.IsNullOrEmpty(config.ImapPasswordEncrypted))
                    config.ImapPassword = CryptoHelper.Decrypt(config.ImapPasswordEncrypted);
                if (!string.IsNullOrEmpty(config.SmtpPasswordEncrypted))
                    config.SmtpPassword = CryptoHelper.Decrypt(config.SmtpPasswordEncrypted);
            }

            return config;
        }
    }
}
