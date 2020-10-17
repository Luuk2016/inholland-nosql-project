using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using MailKit.Net.Smtp;
using MimeKit;

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
         * Send the reset token by email
         * @param UserModel user - the user information
         * @param string token - the reset token
        */
        public void MailResetToken(UserModel user, string token)
        {
            var message = new MimeMessage();
            message.From.Add(new MailboxAddress("NoDesk", "nodesk@luukkenselaar.nl"));
            message.To.Add(new MailboxAddress($"{user.firstName} {user.lastName}", user.email));
            message.Subject = "Your password reset token";

            message.Body = new TextPart("plain")
            {
                Text = $@"Hey {user.firstName},

Here you have your token that can be used to reset your password:
Token: {token}

-- NoDesk"
            };

            using (var client = new SmtpClient())
            {
                client.Connect("mail.luukkenselaar.nl", 587, false);

                // Note: only needed if the SMTP server requires authentication
                client.Authenticate("nodesk@luukkenselaar.nl", "N4M0u3cS");

                client.Send(message);
                client.Disconnect(true);
            }
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

        /*
         * Mark the reset token as used
         * @param string token - the reset token
        */
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

        /*
         * Get the password reset information by the token
         * @param string token - the reset token
        */
        public PasswordResetModel GetPasswordReset(string token)
        {
            return GetRecordByKeyValue<PasswordResetModel>("password-resets", "token", token);
        }
    }
}
