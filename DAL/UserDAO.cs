using System;
using System.Collections.Generic;
using Model;


namespace DAL
{
    public class UserDAO : MongoBase
    {
        public void CreateUser(UserModel user)
        {
            InsertRecord("users", user);
        }

        public UserModel ReadUser(string guid)
        {
            return LoadRecordById<UserModel>("users", new Guid(guid));
        }

        public List<UserModel> ReadUsers()
        {
            return LoadRecords<UserModel>("users");
        }

        public void DeleteUser(string userID)
        {
            
        }
    }
}
