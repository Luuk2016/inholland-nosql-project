using Model;
using Service;
using System;
using System.Windows.Forms;
using UI.GlobalPage;
using OtherFunctions;

namespace UI.Panels
{
    public partial class AddUser : BaseForm
    {
        public EventHandler btnCancelClick;
        private UserService uService;

        public AddUser()
        {
            InitializeComponent();
            uService = new UserService();
        }
        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            if (txt_FirstName.Text != "" && txt_LastName.Text != "" && cmb_TypeUser.Text != "" && txt_Email.Text != "" && txt_PhoneNumber.Text != "" && cmb_Location.Text != "" && txt_Password.Text != "")
            {
                UserModel user = new UserModel();

                user.firstName = txt_FirstName.Text;
                user.lastName = txt_LastName.Text;
                user.type = cmb_TypeUser.Text;
                user.email = txt_Email.Text;
                user.phoneNumber = txt_PhoneNumber.Text;
                user.location = cmb_Location.Text;
                user.hashedPassword = Cryptography.GeneratePasswordHash(txt_Password.Text);
                user.salt = Cryptography.GetSalt();

                uService.CreateUser(user);

                MessageBox.Show("The user has been created!", "Operation successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Not all fields are filled in", "Action failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            btnCancelClick?.Invoke(sender, e);
        }
    } 
}
