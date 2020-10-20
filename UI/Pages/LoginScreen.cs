using System;
using System.Drawing;
using System.Windows.Forms;
using UI.GlobalPage;
using Model;
using Service;
using OtherFunctions;
using Bogus;
using System.Collections.Generic;

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

        private IEnumerable<UserModel> GenerateFakeUsers()
        {
            var userGenerator = new Faker<UserModel>()
                .RuleFor(c => c.firstName, f => f.Name.FirstName())
                .RuleFor(c => c.lastName, f => f.Name.LastName())
                .RuleFor(c => c.type, f => "Employee")
                .RuleFor(c => c.email, f => f.Internet.Email())
                .RuleFor(c => c.phoneNumber, f => f.Phone.PhoneNumber())
                .RuleFor(c => c.location, f => f.Address.City())
                .RuleFor(c => c.hashedPassword, f => "6f0d2873bf8b85ddb1b61042acca41bad80fabd176d12e81b04ca5141eb2343a")
                .RuleFor(c => c.salt, f => "427c78c8a0887b8a2a50a914cc654fd8dbd1a562da5d9bb4dfba480a77a5e32a");

            return userGenerator.Generate(99);
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
                    UserModel user = uService.LoginUser(txtbEmail.Text, txtbPassword.Text) ;

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
