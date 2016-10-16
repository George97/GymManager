using System.Security.Cryptography;
using System.Text;

namespace GymManager
{
    public static class Encrypt
    {
        public static string GetHash(string text)
        {
            using (MD5 cryptoProvider = new MD5CryptoServiceProvider())
            {
                byte[] result = cryptoProvider.ComputeHash(Encoding.Default.GetBytes(text));

                var stringHash = new StringBuilder();

                foreach (var r in result)
                {
                    stringHash.Append(r.ToString("x2"));
                }

                return stringHash.ToString();
            }
        }
    }
}
