using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace AesEncDec
{
   class AesCryptography
   {
      public static string IV = "n6nfjsol12pod87v"; //16 characters
      public static string Key = "mhj2kf8cn4a0cb7htfwsmij721s2hbr5"; //32 characters

      public static string Encrypt(string decrypted)
      {
         byte[] textBytes = ASCIIEncoding.ASCII.GetBytes(decrypted);
         AesCryptoServiceProvider encryptDecrypt = new AesCryptoServiceProvider();
         encryptDecrypt.BlockSize = 128;
         encryptDecrypt.KeySize = 256;
         encryptDecrypt.Key = ASCIIEncoding.ASCII.GetBytes(Key);
         encryptDecrypt.IV = ASCIIEncoding.ASCII.GetBytes(IV);
         encryptDecrypt.Padding = PaddingMode.PKCS7;
         encryptDecrypt.Mode = CipherMode.CBC;

         ICryptoTransform crypt = encryptDecrypt.CreateEncryptor(encryptDecrypt.Key, encryptDecrypt.IV);

         byte[] encrypt = crypt.TransformFinalBlock(textBytes, 0, textBytes.Length);
         crypt.Dispose();

         return Convert.ToBase64String(encrypt);
      }

      public static string Decrypt(string encrypted)
      {
         byte[] encryptedBytes = Convert.FromBase64String(encrypted);
         AesCryptoServiceProvider encryptDecrypt = new AesCryptoServiceProvider();
         encryptDecrypt.BlockSize = 128;
         encryptDecrypt.KeySize = 256;
         encryptDecrypt.Key = ASCIIEncoding.ASCII.GetBytes(Key);
         encryptDecrypt.IV = ASCIIEncoding.ASCII.GetBytes(IV);
         encryptDecrypt.Padding = PaddingMode.PKCS7;
         encryptDecrypt.Mode = CipherMode.CBC;

         ICryptoTransform crypt = encryptDecrypt.CreateDecryptor(encryptDecrypt.Key, encryptDecrypt.IV);

         byte[] decrypt = crypt.TransformFinalBlock(encryptedBytes, 0, encryptedBytes.Length);
         crypt.Dispose();

         return ASCIIEncoding.ASCII.GetString(decrypt);
      }

   }
}
