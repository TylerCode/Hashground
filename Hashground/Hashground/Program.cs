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

            
        }

        private static void EncryptText(string publicKey, string text, string fileName)
        {

        }

        private static string DecryptText(string privateKey, string fileName)
        {
            return "";
        }
    }
}
