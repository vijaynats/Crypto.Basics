using System;
using System.Text;
using System.IO;

namespace Crypto.Basics
{
    public class HashForFile
    {
        public static void Run()
        {
            string fileName = "";

            do
            {
                try
                {
                    Console.WriteLine("** Generate Hash values for large text file **");
                    Console.Write("Enter Filename : ");
                    fileName = Console.ReadLine();

                    Console.WriteLine("Reading text from file : {0}....", fileName);
                    StreamReader reader = new StreamReader(fileName);
                    string fileText = reader.ReadToEnd();
                    Console.WriteLine("Total {0} bytes", fileText.Length);

                    Console.WriteLine("Computing hash....");

                    Console.WriteLine("SHA2 hash : {0}", Hasher.getSHA2Hash(fileText));

                    Console.Write("\nEnter Authkey for HMAC Hash : ");
                    string authKey = Console.ReadLine();

                    Console.WriteLine("SHA2 HMAC Hash : {0}", Hasher.getSHA2HMACHash(fileText, authKey));
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Exception during file/hash operation : {0}\n{1}", ex.Message, ex.ToString());
                }

                Console.Write("Try again (y/n) : ");

            } while (Console.ReadLine() == "y");
        }
    }
}
