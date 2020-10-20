using System;
using System.Drawing;
using System.Windows.Forms;
using UI.GlobalPage;
using Model;
using Service;
using OtherFunctions;

namespace UI.Pages
{
    public partial class LoginScreen : BaseForm
    {
        public EventHandler btnForgotPasswordClick;
        public EventHandler btnLoginClick;
        private UserService uService;
        private bool useLogin;

        public LoginScreen()
        {
            InitializeComponent();

            // Initialize the UserService
            uService = new UserService();

            // Disable/enable the login functionality (for debugging)
            useLogin = true;
        }

        private void lblForgotPassword_MouseClick(object sender, MouseEventArgs e)
        {
            btnForgotPasswordClick?.Invoke(sender, e);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Check if login should be used
            if (useLogin)
            {
                // Check if the username + password have been filled in
                if (txtbEmail.Text != "" && txtbPassword.Text != "")
                {
                    // Get the user by using the filled in email
                    UserModel user = uService.LoginUser(txtbEmail.Text, txtbPassword.Text);

                    // Check if the user has been found
                    if (user != null)
                    {
                        // Set the session
                        Session.user = user;

                        // Clear the fields
                        txtbEmail.Clear();
                        txtbPassword.Clear();

                        // Open the new dashboard
                        btnLoginClick?.Invoke(sender, e);
                    }
                    else
                    {
                        // Credentials incorrect, show an error
                        MessageBox.Show("Email or password is incorrect!", "Login denied", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtbPassword.Clear();
                    }
                }
                else
                {
                    // Not all fields are filled in, show a warning
                    MessageBox.Show("Please fill in all the required fields!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtbEmail.Focus();
                }
            }
            else
            {
                // Open the new dashboard
                btnLoginClick?.Invoke(sender, e);
            }
        }
        
        private void lblForgotPassword_Click(object sender, EventArgs e)
        {
            PasswordResetScreen resetScreen = new PasswordResetScreen();
            resetScreen.Show();
        }

        private void lblForgotPassword_MouseEnter(object sender, EventArgs e)
        {
            lblForgotPassword.Font = new Font(lblForgotPassword.Font, FontStyle.Underline);
        }

        private void lblForgotPassword_MouseLeave(object sender, EventArgs e)
        {
            lblForgotPassword.Font = new Font(lblForgotPassword.Font, FontStyle.Regular);
        }
    }
}
