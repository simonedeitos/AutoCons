using Microsoft.Win32;

namespace AutoCons.Helpers
{
    public static class RegistryHelper
    {
        private const string BasePath = @"Software\AutoCons";

        public static void SaveValue(string subKey, string name, string value)
        {
            using var key = Registry.CurrentUser.CreateSubKey($@"{BasePath}\{subKey}", true);
            key.SetValue(name, value, RegistryValueKind.String);
        }

        public static string? LoadValue(string subKey, string name)
        {
            using var key = Registry.CurrentUser.OpenSubKey($@"{BasePath}\{subKey}", false);
            return key?.GetValue(name) as string;
        }

        public static Dictionary<string, string> LoadAllValues(string subKey)
        {
            var result = new Dictionary<string, string>();
            using var key = Registry.CurrentUser.OpenSubKey($@"{BasePath}\{subKey}", false);
            if (key == null) return result;

            foreach (var name in key.GetValueNames())
            {
                var val = key.GetValue(name) as string;
                if (val != null)
                    result[name] = val;
            }
            return result;
        }

        public static bool Exists(string subKey, string name)
        {
            using var key = Registry.CurrentUser.OpenSubKey($@"{BasePath}\{subKey}", false);
            return key?.GetValue(name) != null;
        }

        public static void DeleteValue(string subKey, string name)
        {
            using var key = Registry.CurrentUser.OpenSubKey($@"{BasePath}\{subKey}", true);
            key?.DeleteValue(name, false);
        }

        public static void ClearSubKey(string subKey)
        {
            Registry.CurrentUser.DeleteSubKeyTree($@"{BasePath}\{subKey}", false);
        }
    }
}
