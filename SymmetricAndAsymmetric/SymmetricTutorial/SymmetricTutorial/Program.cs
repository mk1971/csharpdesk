using System;
using System.Security.Cryptography;
using System.IO;

namespace SymmetricTutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a new instance of the AES algorithm 
            SymmetricAlgorithm aes = new AesManaged();

            byte[] key = aes.Key; // Key propery contains the key of the aes algorithm you can create your own 

            Console.WriteLine("Enter your message here to encrypt:");
            string message = Console.ReadLine(); 

            // Call the encryptText method to encrypt the a string and save the result to a file 
            EncryptText(aes, message, "encryptedData.dat");

            // Call the decryptData method to get the encrypted text from the file and print it 
            Console.WriteLine("Decrypted Message: {0} ", DecryptData(aes, "encryptedData.dat")); 


            
        }

        // Method to encrypte a string data and save it in a specific file using an AES algorithm
        static void EncryptText(SymmetricAlgorithm aesAlgorithm,string text,string fileName)
        {
            // Create an encryptor from the AES algorithm instance and pass the aes algorithm key and inialiaztion vector to generate a new random sequence each time for the same text
            ICryptoTransform encryptor = aesAlgorithm.CreateEncryptor(aesAlgorithm.Key, aesAlgorithm.IV);

            // Create a memory stream to save the encrypted data in it
            using (MemoryStream ms = new MemoryStream())
            {
                using (CryptoStream cs = new CryptoStream(ms,encryptor,CryptoStreamMode.Write))
                {
                    using (StreamWriter writer = new StreamWriter(cs))
                    {
                        // Write the text in the stream writer 
                        writer.Write(text);
                    }
                }

                // Get the result as a byte array from the memory stream 
                byte[] encryptedDataBuffer = ms.ToArray();

                // Write the data to a file 
                File.WriteAllBytes(fileName, encryptedDataBuffer);
            }
        }

        // Method to decrypt a data from a specific file and return the result as a string 
        static string DecryptData(SymmetricAlgorithm aesAlgorithm, string fileName)
        {
            // Create a decryptor from the aes algorithm 
            ICryptoTransform decryptor = aesAlgorithm.CreateDecryptor(aesAlgorithm.Key, aesAlgorithm.IV);

            // Read the encrypted bytes from the file 
            byte[] encryptedDataBuffer = File.ReadAllBytes(fileName); 

            // Create a memorystream to write the decrypted data in it 
            using (MemoryStream ms = new MemoryStream(encryptedDataBuffer))
            {
                using (CryptoStream cs = new CryptoStream(ms, decryptor, CryptoStreamMode.Read))
                {
                    using (StreamReader reader = new StreamReader(cs))
                    {
                        // Reutrn all the data from the streamreader 
                        return reader.ReadToEnd(); 
                    }
                }
            }
        }
    }
}
