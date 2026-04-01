using System.Text.RegularExpressions;

namespace AutoCons.Services
{
    public static class PhoneNormalizer
    {
        private static readonly string[] InternationalPrefixes = new[]
        {
            "+390", "+39", "0039",
            "+330", "+33", "0033",
            "+440", "+44", "0044",
            "+10",  "+1",  "001",
            "+490", "+49", "0049",
            "+340", "+34", "0034",
            "+310", "+31", "0031",
            "+320", "+32", "0032",
            "+410", "+41", "0041",
            "+430", "+43", "0043",
        };

        public static string Normalize(string phone)
        {
            if (string.IsNullOrWhiteSpace(phone))
                return string.Empty;

            // Remove spaces, dashes, dots, parentheses
            var result = Regex.Replace(phone.Trim(), @"[\s\-\.\(\)]", string.Empty);

            // Remove international prefixes (try longest first)
            var sortedPrefixes = InternationalPrefixes
                .OrderByDescending(p => p.Length)
                .ToArray();

            foreach (var prefix in sortedPrefixes)
            {
                if (result.StartsWith(prefix, StringComparison.OrdinalIgnoreCase))
                {
                    result = result.Substring(prefix.Length);
                    break;
                }
            }

            // Remove trailing semicolon if present
            result = result.TrimEnd(';').Trim();

            return result;
        }
    }
}
