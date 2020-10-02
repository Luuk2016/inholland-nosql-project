using System;
using System.Security.Cryptography;
using System.Text;

namespace OtherFunctions
{
    public static class Cryptography
    {
        /*
         * Generate a password hash with salt
         * @param string password - the users password
         * @param string hash2 - the generated salt
         * @return string - the hashed password
         */
        public static string GeneratePasswordHash(string password, string salt)
        {
            // Create a new SHA256Managed object for later use
            SHA256Managed crypt = new SHA256Managed();

            // Define variables 
            string hash = String.Empty;

            // Append the salt to the password
            string toHash = password + salt;

            // Hash the toHash string and store it in bytes in the crypto var
            byte[] crypto = crypt.ComputeHash(Encoding.ASCII.GetBytes(toHash));

            // Go over each byte and convert it to a readable string
            foreach (byte b in crypto)
            {
                hash += b.ToString("x2");
            }

            // Return the final hash
            return hash;
        }

        /*
         * Check if two hashes are the same
         * @param string hash1 - the first hash
         * @param string hash2 - the second hash
         * @return bool - true if they are the same, otherwise false
         */
        public static bool CompareHashes(string hash1, string hash2)
        {
            return hash1.Equals(hash2);
        }
    }
}
