using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crypto.Basics
{
    public class HashForString
    {
        public static void Run()
        {
            do
            {
                Console.WriteLine("** Computes Hash of input string using .NET Crypto Library");
                Console.Write("Enter a String : ");
                string str = Console.ReadLine();

                Console.WriteLine("Computing MD5 hash...");

                string shash = Hasher.getMD5Hash(str);
                string s1hash = Hasher.getSHA1Hash(str);
                string s2hash = Hasher.getSHA2Hash(str);

                Console.WriteLine("MD5 Hash is : {0}\nLength of Hash : {1}", shash, shash.Length);
                Console.WriteLine("SHA1 Hash is : {0}\nLength of Hash : {1}", s1hash, s1hash.Length);
                Console.WriteLine("SHA2 Hash is : {0}\nLength of Hash : {1}", s2hash, s2hash.Length);

                Console.Write("Try again ? (y/n) : ");
            } while (Console.ReadLine() == "y");
        }
    }
}
