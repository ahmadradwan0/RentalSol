using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;

namespace Rental.Services.Encryptions
{
    public static class Encryptor
    {
        public static string HashPasswordSHA1(string passwd)

        {
            // Convert the password to a byte array
            byte[] passwdBytes = Encoding.UTF8.GetBytes(passwd);

            // Create a new instance of the SHA1CryptoServiceProvider to compute the hash
            using (var sha1 = new SHA1CryptoServiceProvider())
            {
                // Compute the hash of the password
                byte[] hashBytes = sha1.ComputeHash(passwdBytes);

                // Convert the hash to a fixed-length string
                string hashedPasswd = BitConverter.ToString(hashBytes).Replace("-", "").ToLower();

                return hashedPasswd;
            }
        }

        public static string HashPasswordSHA256(string passwd)
        {
            // Convert the password to a byte array
            byte[] passwdBytes = Encoding.UTF8.GetBytes(passwd);

            // Create a new instance of the SHA1CryptoServiceProvider to compute the hash
            using (SHA256 sha256 = SHA256.Create())
            {
                // Compute the hash of the password
                byte[] hashBytes = sha256.ComputeHash(passwdBytes);

                // Convert the hash to a fixed-length string
                string hashedPasswd = BitConverter.ToString(hashBytes).Replace("-", "").ToLower();

                return hashedPasswd;
            }
        }


    }
}