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

        public void MailResetToken(UserModel user, string token)
        {
            pwrDAO.MailResetToken(user, token);
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
