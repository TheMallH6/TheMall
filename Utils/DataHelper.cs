using System.Security.Cryptography;
using System.Text;

namespace TheMall.Utils
{
    public static class DataHelper
    {
        public static string ToSha256(this string input)
        {
            var sha256 = SHA256.Create();
            return BitConverter.ToString(sha256.ComputeHash(Encoding.UTF8.GetBytes(input))).Replace("-", "");
        }


    }
}
