using System.Diagnostics;

namespace AutoCons.Services
{
    public static class SchedulerService
    {
        private const string SenderTaskName = "AutoCons_Sender";
        private const string ReceiverTaskName = "AutoCons_Receiver";

        public static void CreateOrUpdateSenderTask(
            List<int> scheduledDays,
            TimeSpan minTime,
            TimeSpan maxTime)
        {
            string exePath = Process.GetCurrentProcess().MainModule?.FileName
                             ?? Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "AutoCons.exe");

            // Delete existing tasks (ignore failures — task may not exist yet)
            foreach (int day in scheduledDays)
                _ = RunSchtasks($"/Delete /TN \"{SenderTaskName}_Day{day}\" /F");

            // Also try deleting the base task name (legacy cleanup)
            _ = RunSchtasks($"/Delete /TN \"{SenderTaskName}\" /F");

            // Create one trigger per scheduled day with a random time in the range
            var rng = new Random();
            int rangeMinutes = (int)(maxTime - minTime).TotalMinutes;
            var failures = new List<string>();

            foreach (int day in scheduledDays)
            {
                int offsetMinutes = rng.Next(0, Math.Max(1, rangeMinutes));
                var triggerTime = minTime.Add(TimeSpan.FromMinutes(offsetMinutes));
                string timeStr = triggerTime.ToString(@"hh\:mm");

                // Use MONTHLY trigger with specific day
                var args = $"/Create /TN \"{SenderTaskName}_Day{day}\" " +
                           $"/TR \"\\\"{exePath}\\\" --run-sender\" " +
                           $"/SC MONTHLY /D {day} /ST {timeStr} " +
                           $"/F /RL LIMITED";

                var (success, output) = RunSchtasks(args);
                if (!success)
                    failures.Add($"Giorno {day}: {output}");
            }

            if (failures.Count > 0)
                throw new InvalidOperationException(
                    $"Errore nella creazione dei task pianificati:\n{string.Join("\n", failures)}");

            LogService.Info($"Task Scheduler: task '{SenderTaskName}' creato/aggiornato per {scheduledDays.Count} giorni");
        }

        public static void CreateOrUpdateReceiverTask(TimeSpan checkTime)
        {
            string exePath = Process.GetCurrentProcess().MainModule?.FileName
                             ?? Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "AutoCons.exe");

            string timeStr = checkTime.ToString(@"hh\:mm");

            // Delete existing task (ignore failure — task may not exist yet)
            _ = RunSchtasks($"/Delete /TN \"{ReceiverTaskName}\" /F");

            var args = $"/Create /TN \"{ReceiverTaskName}\" " +
                       $"/TR \"\\\"{exePath}\\\" --run-receiver\" " +
                       $"/SC DAILY /ST {timeStr} " +
                       $"/F /RL LIMITED";

            var (success, output) = RunSchtasks(args);
            if (!success)
                throw new InvalidOperationException($"Errore nella creazione del task: {output}");

            LogService.Info($"Task Scheduler: task '{ReceiverTaskName}' creato/aggiornato alle {timeStr}");
        }

        private static (bool Success, string Output) RunSchtasks(string arguments)
        {
            var psi = new ProcessStartInfo
            {
                FileName = "schtasks.exe",
                Arguments = arguments,
                UseShellExecute = false,
                RedirectStandardOutput = true,
                RedirectStandardError = true,
                CreateNoWindow = true
            };

            using var process = Process.Start(psi);
            if (process == null) return (false, "Impossibile avviare schtasks.exe");

            string output = process.StandardOutput.ReadToEnd();
            string error = process.StandardError.ReadToEnd();
            process.WaitForExit();

            if (process.ExitCode != 0)
            {
                string errorMsg = !string.IsNullOrWhiteSpace(error) ? error.Trim() : output.Trim();
                return (false, errorMsg);
            }

            if (!string.IsNullOrWhiteSpace(output))
                LogService.Info($"schtasks: {output.Trim()}");

            return (true, output.Trim());
        }
    }
}

