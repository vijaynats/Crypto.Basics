using System;
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
            do
            {
                Console.WriteLine("** Computes MD5 Hash using .NET Crypto Library");
                Console.Write("Enter a String : ");
                string str = Console.ReadLine();

                Console.WriteLine("Computing MD5 hash...");

                string shash = MD5Hasher.getMD5Hash(str);

                Console.WriteLine("MD5 Hash is : {0}\nLength of Hash : {1}", shash, shash.Length);
                Console.Write("Try again ? (y/n) : ");
            } while (Console.ReadLine() == "y");
        }
    }
}
