using System;
using System.Collections.Generic;
using Model;
using MongoDB.Driver;
using OtherFunctions;

namespace DAL
{
    public class UserDAO : MongoBase
    {
        /*
         * Login the user
         * @param string email - the filled in email
         * @param string password - the filled in password
         * @return UserModel user - object with user details
         */
        public UserModel LoginUser(string email, string password)
        {
            // Create a filter that will get the user by email
            var filter = Builders<UserModel>.Filter.Eq("email", email);

            // Get the user or null
            UserModel user = GetRecordByFilter("users", filter);

            // If no user has been found return NULL
            if (user == null)
            {
                return null;
            }

            // Store the db stored password + salt
            string storedPW = user.hashedPassword;
            string storedSalt = user.salt;

            // Generate the hash with the filled in password + stored salt
            string inputPW = Cryptography.GeneratePasswordHash(password);

            // Compare the filled in (hashed) password with the hash stored in the database
            if (Cryptography.CompareHashes(inputPW, storedPW))
            {
                return user;
            }
            else
            {
                return null;
            }
        }

        /*
         * Create a new user
         * @param UserModel user - a UserModel object
         */
        public void CreateUser(UserModel user)
        {
            InsertRecord("users", user);
        }

        /*
         * Get a user by ID
         * @param string id - the id of the user
         * @return UserModel - the user
         */
        public UserModel GetUserById(string id)
        {
            return GetRecordById<UserModel>("users", id);
        }

        /*
         * Get all users
         * @return List<UserModel> - all the users
         */
        public List<UserModel> GetUsers()
        {
            return GetTable<UserModel>("users");
        }

        /*
        * Delete a user
        * @param string id - the id of the user
        */
        public void DeleteUser(string id)
        {
            DeleteRecordById<UserModel>("users", id);
        }
    }
}
