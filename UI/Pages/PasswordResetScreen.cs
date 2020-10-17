using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Service;
using Model;
using OtherFunctions;

namespace UI.Pages
{
    public partial class PasswordResetScreen : Form
    {
        private UserService uService;
        private PasswordResetService pwrService;
      
        public PasswordResetScreen()
        {
            InitializeComponent();

            // Initialize the objects
            uService = new UserService();
            pwrService = new PasswordResetService();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            // Check if the field has been filled in
            if (txtEmail.Text != "")
            {
                // Check if the user exists
                if (uService.CheckIfUserExists(txtEmail.Text))
                {
                    // Create a new object
                    PasswordResetModel passwordReset = new PasswordResetModel();

                    // Set the details (user his email plus a random token)
                    passwordReset.email = txtEmail.Text;
                    passwordReset.token = Cryptography.GetRandomToken();
                    passwordReset.used = false;

                    // Create a new record in the database
                    pwrService.CreatePasswordReset(passwordReset);

                    // Mail the user his code



                }

                // Show a messagebox
                MessageBox.Show("If the email matches our records, an email has been sent.", "Please check your email", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Disable the previous fields
                txtEmail.Enabled = false;
                btnGetToken.Enabled = false;

                // Enable the next fields
                txtToken.Enabled = true;
                txtNewPassword.Enabled = true;
                txtConfirmNewPassword.Enabled = true;
                btnConfirm.Enabled = true;
            }
            else
            {
                MessageBox.Show("Please fill in the required field!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmail.Focus();
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            // Check if all the fields has been filled in
            if (txtToken.Text != "" && txtNewPassword.Text != "" && txtConfirmNewPassword.Text != "")
            {
                // Check if the new passwords are the same
                if (txtNewPassword.Text == txtConfirmNewPassword.Text)
                {
                    // Check if the code is valid
                    if (pwrService.CheckIfTheResetTokenIsValid(txtToken.Text))
                    {
                        // Get the passwordreset request
                        PasswordResetModel passwordReset = pwrService.GetPasswordReset(txtToken.Text);

                        // Get the user
                        UserModel user = uService.GetUserByEmail(passwordReset.email);

                        // Generate a new password
                        string newPassword = txtNewPassword.Text;

                        // Hash the password
                        user.hashedPassword = Cryptography.GeneratePasswordHash(newPassword);

                        // Update the password
                        uService.UpdateUser(user);

                        // Mark the reset token as used
                        pwrService.MarkResetTokenAsUsed(txtToken.Text);

                        MessageBox.Show("Your new password has been set!", "Action succesful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtToken.Focus();
                    }
                    else
                    {
                        MessageBox.Show("Token invalid or already used!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtToken.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("New passwords doesn't match!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Please fill in all the required fields!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtToken.Focus();
            }
        }
    }
}
