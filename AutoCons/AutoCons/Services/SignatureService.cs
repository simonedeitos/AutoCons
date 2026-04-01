using System.Security.Cryptography;
using System.Text;

namespace AutoCons.Services
{
    public static class SignatureService
    {
        public static string Sign(string body, string sharedKey)
        {
            var keyBytes = Encoding.UTF8.GetBytes(sharedKey);
            var bodyBytes = Encoding.UTF8.GetBytes(body);
            using var hmac = new HMACSHA256(keyBytes);
            var hash = hmac.ComputeHash(bodyBytes);
            return Convert.ToHexString(hash).ToLowerInvariant();
        }

        public static bool Verify(string body, string signature, string sharedKey)
        {
            if (string.IsNullOrEmpty(signature)) return false;
            var expected = Sign(body, sharedKey);
            return string.Equals(expected, signature, StringComparison.OrdinalIgnoreCase);
        }
    }
}
