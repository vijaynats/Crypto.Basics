using System;
using System.IO;
using System.Text;
using System.Security;
using System.Security.Cryptography;

namespace Crypto.Basics
{
    public class Program
    {
        // Generate a MD5 hash
        public static void Main(string[] args)
        {
            HashForFile.Run();
        }
    }
}
