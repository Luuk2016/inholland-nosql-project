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

        public List<UserModel> GetUsers()
        {
            return userDAO.GetUsers();
        }

        public UserModel GetUserById(string id)
        {
            return userDAO.GetUserById(id);
        }

        public void DeleteUser(string id)
        {
            userDAO.DeleteUser(id);
        }
    }
}
