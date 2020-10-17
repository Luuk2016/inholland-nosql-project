using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Model;

namespace Service
{
    public class UserService
    {
        private UserDAO userDAO;

        public UserService()
        {
            userDAO = new UserDAO();
        }

        public UserModel LoginUser(string email, string password)
        {
            return userDAO.LoginUser(email, password);
        }

        public void CreateUser(UserModel user)
        {
            userDAO.CreateUser(user);
        }

        public bool CheckIfUserExists(string email)
        {
            return userDAO.CheckIfUserExists(email);
        }

        public List<UserModel> GetUsers()
        {
            return userDAO.GetUsers();
        }

        public void UpdateUser(UserModel user)
        {
            userDAO.UpdateUser(user);
        }

        public UserModel GetUserById(string id)
        {
            return userDAO.GetUserById(id);
        }

        public UserModel GetUserByEmail(string email)
        {
            return userDAO.GetUserByEmail(email);
        }

        public void DeleteUser(string id)
        {
            userDAO.DeleteUser(id);
        }
    }
}
