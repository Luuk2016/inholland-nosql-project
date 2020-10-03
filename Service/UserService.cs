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

        public void CreateUser(UserModel user)
        {
            userDAO.CreateUser(user);
        }

        public List<UserModel> ReadUsers()
        {
            return userDAO.ReadUsers();
        }

        public UserModel ReadUser(string guid)
        {
            return userDAO.ReadUser(guid);
        }
    }
}
