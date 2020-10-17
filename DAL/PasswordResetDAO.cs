using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace DAL
{
    public class PasswordResetDAO : MongoBase
    {
        /*
        * Creates a new passwordReset 
        * @param PasswordResetModel passwordReset - the details about the reset request
        */
        public void CreatePasswordReset(PasswordResetModel passwordReset)
        {
            InsertRecord("password-resets", passwordReset);
        }

        /*
        * Checkes if the the reset token is valid
        * @param string token - the reset token
        * @return bool - true if valid, false if not
        */
        public bool CheckIfTheResetTokenIsValid(string token)
        {
            bool valid = false;

            // Get the PasswordReset data using the token
            PasswordResetModel reset = GetRecordByKeyValue<PasswordResetModel>("password-resets", "token", token);

            // Check if the token has not been used yet
            if (reset != null && !reset.used)
            {
                valid = true;
            }

            return valid;
        }

        public void MarkResetTokenAsUsed(string token)
        {
            // Get the PasswordReset data using the token
            PasswordResetModel reset = GetRecordByKeyValue<PasswordResetModel>("password-resets", "token", token);

            // Check if the passwordreset is not null or is already been used
            if (reset != null && !reset.used)
            {
                reset.used = true;

                UpdateRecord<PasswordResetModel>("password-resets", reset.id.ToString(), reset);
            }
        }

        public PasswordResetModel GetPasswordReset(string token)
        {
            return GetRecordByKeyValue<PasswordResetModel>("password-resets", "token", token);
        }
    }
}
