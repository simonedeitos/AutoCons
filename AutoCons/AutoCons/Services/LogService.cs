using System.Text;

namespace AutoCons.Services
{
    public static class LogService
    {
        private static readonly object _lock = new object();

        private static string LogDirectory
        {
            get
            {
                var dir = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Log");
                Directory.CreateDirectory(dir);
                return dir;
            }
        }

        private static string CurrentLogFile =>
            Path.Combine(LogDirectory, $"AutoCons_{DateTime.Now:yyyy-MM-dd}.log");

        public static void Info(string message) => Write("INFO", message);
        public static void Warn(string message) => Write("WARN", message);
        public static void Error(string message) => Write("ERROR", message);
        public static void Error(string message, Exception ex) => Write("ERROR", $"{message}: {ex}");

        private static void Write(string level, string message)
        {
            var line = $"[{DateTime.Now:yyyy-MM-dd HH:mm:ss}] [{level}] {message}";
            lock (_lock)
            {
                File.AppendAllText(CurrentLogFile, line + Environment.NewLine, Encoding.UTF8);
            }
        }
    }
}
