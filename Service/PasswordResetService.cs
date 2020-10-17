using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using DAL;

namespace Service
{
    public class PasswordResetService
    {
        private PasswordResetDAO pwrDAO;

        public PasswordResetService()
        {
            pwrDAO = new PasswordResetDAO();
        }

        public void CreatePasswordReset(PasswordResetModel passwordReset)
        {
            pwrDAO.CreatePasswordReset(passwordReset);
        }

        public bool CheckIfTheResetTokenIsValid(string token)
        {
            return pwrDAO.CheckIfTheResetTokenIsValid(token);
        }

        public void MarkResetTokenAsUsed(string token)
        {
            pwrDAO.MarkResetTokenAsUsed(token);
        }

        public PasswordResetModel GetPasswordReset(string token)
        {
            return pwrDAO.GetPasswordReset(token);
        }
    }
}
