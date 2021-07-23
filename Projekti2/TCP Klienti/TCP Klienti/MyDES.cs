using System;
using System.Security.Cryptography;
using System.Text;
using System.IO;

namespace TCP_Klienti
{
    public class MyDES
    {

        private static byte[] iv = GenerateRandomBytes(30);
        private static byte[] key = GenerateRandomBytes(8);

        public static byte[] GenerateRandomBytes(int length)
        {
            byte[] randBytes;

            if (length >= 1)
            {
                randBytes = new byte[length];
            }
            else
            {
                randBytes = new byte[1];
            }

            System.Security.Cryptography.RNGCryptoServiceProvider rand =
            new System.Security.Cryptography.RNGCryptoServiceProvider();

            rand.GetBytes(randBytes);

            return randBytes;
        }

       
        public static byte[] EncryptTextToMemory(string Data, byte[] Key, byte[] IV)
        {
            try
            {
                MemoryStream mStream = new MemoryStream();

                CryptoStream cStream = new CryptoStream(mStream,
                    new DESCryptoServiceProvider().CreateEncryptor(Key, IV),
                    CryptoStreamMode.Write);

                byte[] toEncrypt = new ASCIIEncoding().GetBytes(Data);


                cStream.Write(toEncrypt, 0, toEncrypt.Length);
                cStream.FlushFinalBlock();

                byte[] ret = mStream.ToArray();

                cStream.Close();
                mStream.Close();

                return ret;
            }
            catch (CryptographicException e)
            {
                Console.WriteLine("A Cryptographic error occurred: {0}", e.Message);
                return null;
            }

        }

        public static string DecryptTextFromMemory(byte[] Data, byte[] Key, byte[] IV)
        {
            try
            {
  
                MemoryStream msDecrypt = new MemoryStream(Data);

                CryptoStream csDecrypt = new CryptoStream(msDecrypt,
                    new DESCryptoServiceProvider().CreateDecryptor(Key, IV),
                    CryptoStreamMode.Read);

                byte[] fromEncrypt = new byte[Data.Length];

                
                csDecrypt.Read(fromEncrypt, 0, fromEncrypt.Length);

                return new ASCIIEncoding().GetString(fromEncrypt);
            }
            catch (CryptographicException e)
            {
                Console.WriteLine("A Cryptographic error occurred: {0}", e.Message);
                return null;
            }
        }
    }
}