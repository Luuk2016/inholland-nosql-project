using System;
using System.Drawing;
using System.Windows.Forms;
using UI.GlobalPage;

namespace UI.Pages
{
    public partial class LoginScreen : BaseForm
    {
        public EventHandler btnForgotPasswordClick;
        public EventHandler btnLoginClick;

        public LoginScreen()
        {
            InitializeComponent();
        }

        private void lblForgotPassword_MouseClick(object sender, MouseEventArgs e)
        {
            btnForgotPasswordClick?.Invoke(sender, e);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            btnLoginClick?.Invoke(sender, e);
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
