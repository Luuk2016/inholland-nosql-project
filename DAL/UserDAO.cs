using System;
using System.Collections.Generic;
using Model;


namespace DAL
{
    public class UserDAO : MongoBase
    {
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
