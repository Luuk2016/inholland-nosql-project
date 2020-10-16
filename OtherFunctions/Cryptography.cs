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
         * @return string - the hashed password
        */
        public static string GeneratePasswordHash(string password)
        {
            // Create a new SHA256Managed object for later use
            SHA256Managed crypt = new SHA256Managed();

            // Define variables 
            string hash = String.Empty;

            // Append the salt to the password
            string toHash = password + GetSalt();

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

        /*
         * Get a salt to use with the hashing
         * @return string - the salt
        */
        public static string GetSalt()
        {
            return "427c78c8a0887b8a2a50a914cc654fd8dbd1a562da5d9bb4dfba480a77a5e32a";
        }

        /*
         * Generate a random 15 character token
         * @return string - the random token
        */
        public static string GetToken()
        {
            return Guid.NewGuid().ToString("n").Substring(0, 15);
        }
    }
}