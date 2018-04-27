using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using Hashground.Models;

namespace Hashground
{
    class Program
    {
        private static Shipment shipment;

        static void Main(string[] args)
        {
            shipment = new Shipment(0123, 40, "Pops' Farm", new Classes.Vegetable("Tomato", 300));

            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();
            string pubKey = rsa.ToXmlString(false); //False gives pub key
            string privKey = rsa.ToXmlString(true); //True give private key

            EncryptText(pubKey, shipment.Encode(), "shipment.dat");
            File.WriteAllText("test.txt", shipment.Encode());

            Console.WriteLine("Decrypted Message: {0}", DecryptText(privKey, "shipment.dat"));
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
