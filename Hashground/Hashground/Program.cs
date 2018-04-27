using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace Hashground
{
    class Program
    {
        static void Main(string[] args)
        {
            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();
            string pubKey = rsa.ToXmlString(false); //False gives pub key
            string privKey = rsa.ToXmlString(true); //True give private key

            EncryptText(pubKey, "", "irobot.dat");

            Console.WriteLine("Decrypted Message: {0}", DecryptText(privKey, "irobot.dat"));
        }

        private static void EncryptText(string publicKey, string text, string fileName)
        {
            UnicodeEncoding byteConversion = new UnicodeEncoding();
            byte[] dataToEncrypt = byteConversion.GetBytes(text);

            byte[] encryptedData;

            using (RSACryptoServiceProvider rsa = new RSACryptoServiceProvider())
            {
                rsa.FromXmlString(publicKey);

                encryptedData = rsa.Encrypt(dataToEncrypt, false);
            }

            File.WriteAllBytes(fileName, encryptedData);

            Console.WriteLine("data encrypted");
        }

        private static string DecryptText(string privateKey, string fileName)
        {
            return "";
        }
    }
}
