using System;
using System.Security.Cryptography;
using System.Text;

namespace Crypto.Basics
{
    public class MD5Hasher
    {
        public static string getMD5Hash(string str)
        {
            MD5CryptoServiceProvider hasher = new MD5CryptoServiceProvider();

            return getHexString(hasher.ComputeHash(Encoding.Default.GetBytes(str)));
        }

        private static string getHexString(byte[] bytes)
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < bytes.Length; i++)
            {
                sb.Append(bytes[i].ToString("x2"));
            }

            return sb.ToString();
        }
    }
}
