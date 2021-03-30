using System;

namespace Validation
{
    class Program
    {
        static void Main(string[] args)
        {
            string dataToProtect = "String super secure";
            var key = new byte[] { 12, 2, 56, 117, 12, 67, 33, 23, 12, 2, 56, 117, 12, 67, 33, 23 };

            var EncryptTest = new EncryptDecrypt(key);
            string base64EncryptString = EncryptTest.Encrypt(dataToProtect);

            Console.WriteLine("Encrypt: " + base64EncryptString);

            var DecryptTest = new EncryptDecrypt(key);
            string base64DecryptString = DecryptTest.Decrypt(base64EncryptString);

            Console.WriteLine("Decrypt: " + base64DecryptString);

            Console.Read();
        }
    }
}
