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
      
        public PasswordResetScreen()
        {
            InitializeComponent();

            // Initialize the UserService
            uService = new UserService();
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
                    passwordReset.token = Cryptography.GetToken();

                    // Create a new record in the database
                    uService.CreatePasswordReset(passwordReset);

                    // Mail the user his code
                }

                MessageBox.Show("If the email matches our records, an email has been sent.", "Please check your email", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Please fill in the required field!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmail.Focus();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtEmail.Clear();
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {

        }
    }
}
