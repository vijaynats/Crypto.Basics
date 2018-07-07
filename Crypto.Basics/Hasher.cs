using System;
using System.Security.Cryptography;
using System.Text;

namespace Crypto.Basics
{
    public class Hasher
    {
        public static string getMD5Hash(string str)
        {
            return getHash(str, HashTypes.MD5);
        }

        public static string getSHA1Hash(string str)
        {
            return getHash(str, HashTypes.SHA1);
        }

        public static string getSHA2Hash(string str)
        {
            return getHash(str, HashTypes.SHA256);
        }

        private static string getHash(string str, HashTypes type)
        {
            dynamic hasher = new MD5CryptoServiceProvider();

            switch(type)
            {
                case HashTypes.SHA1:
                    hasher = new SHA1CryptoServiceProvider();
                    break;
                case HashTypes.SHA256:
                    hasher = new SHA256CryptoServiceProvider();
                    break;
            }

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

    public enum HashTypes
    {
        MD5,
        SHA1,
        SHA256
    }
}
