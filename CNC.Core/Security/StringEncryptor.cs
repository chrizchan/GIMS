using System;
using System.Security.Cryptography;
using System.Text;

namespace CNC.Core.Security
{
    public static class StringEncryptor
    {

        //-------SECRATE KEY FOR ENCREPTION AND DECREPTION---------------
        static string key = "SLS123";
        //-------SECRATE KEY FOR ENCREPTION AND DECREPTION---------------

        //For Encryption
        public static string EncryptPassword(string EncryptionText)
        {
            byte[] SecratekeyArray;
            byte[] EncryptArray = UTF8Encoding.UTF8.GetBytes(EncryptionText);
            SecratekeyArray = UTF8Encoding.UTF8.GetBytes(key);
            TripleDESCryptoServiceProvider objtripledes = new TripleDESCryptoServiceProvider();
            //To set the secret key for the tripleDES algorithm
            MD5CryptoServiceProvider objmd5crypto = new MD5CryptoServiceProvider();
            SecratekeyArray = objmd5crypto.ComputeHash(UTF8Encoding.UTF8.GetBytes(key));
            objmd5crypto.Clear();
            objtripledes.Key = SecratekeyArray;
            //Mode of Encreption.
            objtripledes.Mode = CipherMode.ECB;
            objtripledes.Padding = PaddingMode.PKCS7;
            ICryptoTransform cTransform = objtripledes.CreateEncryptor();
            //convert array to resultArray
            byte[] resultArray = cTransform.TransformFinalBlock(EncryptArray, 0, EncryptArray.Length);
            //Release resources
            objtripledes.Clear();
            //For returning the encrypted data into unreadable string format
            return Convert.ToBase64String(resultArray, 0, resultArray.Length);
        }
        //For Decryption
        public static string DecryptPassword(string DecryptText)
        {
            byte[] SecratekeyArray;
            byte[] DecryptArray = Convert.FromBase64String(DecryptText);
            SecratekeyArray = UTF8Encoding.UTF8.GetBytes(key);
            TripleDESCryptoServiceProvider objtripledes = new TripleDESCryptoServiceProvider();
            //set the secret key for the tripleDES algorithm
            MD5CryptoServiceProvider objmd5crypto = new MD5CryptoServiceProvider();
            SecratekeyArray = objmd5crypto.ComputeHash(UTF8Encoding.UTF8.GetBytes(key));
            objmd5crypto.Clear();
            objtripledes.Key = SecratekeyArray;
            //Mode of Encreption.
            objtripledes.Mode = CipherMode.ECB;
            objtripledes.Padding = PaddingMode.PKCS7;
            ICryptoTransform cTransform = objtripledes.CreateDecryptor();
            byte[] resultArray = cTransform.TransformFinalBlock(DecryptArray, 0, DecryptArray.Length);
            //Release resources              
            objtripledes.Clear();
            //For returning the the Clear decrypted TEXT
            return UTF8Encoding.UTF8.GetString(resultArray);
        }
    }
}
