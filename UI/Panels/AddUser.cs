using Model;
using Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI.GlobalPage;

namespace UI.Panels
{
    public partial class AddUser : BaseForm
    {
        public EventHandler btnCancelClick;
        private UserService uService;
        int count = 0;
        public AddUser()
        {
            InitializeComponent();
            uService = new UserService();
            lbl_FirstNameWarning.Hide();
            lbl_LastNameWarning.Hide();
            lbl_LocationWarning.Hide();
            lbl_MailWarning.Hide();
            lbl_PasswordWarning.Hide();
            lbl_PhoneNumberWarning.Hide();
            lbl_TypeWarning.Hide();
            btnAdd.Enabled = false;
        }
        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            UserModel user = new UserModel();
            user.firstName = txt_FirstName.Text;
            user.lastName = txt_LastName.Text;
            user.type = cmb_TypeUser.Text;
            user.email = txt_Email.Text;
            user.phoneNumber = txt_PhoneNumber.Text;
            user.location = cmb_Location.Text;
            user.hashedPassword = txt_Password.Text;
            uService.CreateUser(user);
        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            btnCancelClick?.Invoke(sender, e);
        }

        private void btn_Check_Click(object sender, EventArgs e)
        {
            count = 0;
            if (txt_FirstName.Text != "")
            {
                count++;
            }
            else
            {
                lbl_FirstNameWarning.Show();
            }
            if (txt_LastName.Text != "")
            {
                count++;
            }
            else
            {
                lbl_LastNameWarning.Show();
            }
            if (cmb_TypeUser.Text != "")
            {
                count++;
            }
            else
            {
                lbl_TypeWarning.Show();
            }
            if (txt_Email.Text != "")
            {
                count++;
            }
            else
            {
                lbl_MailWarning.Show();
            }
            if (txt_PhoneNumber.Text != "")
            {
                count++;
            }
            else
            {
                lbl_PhoneNumberWarning.Show();
            }
            if (cmb_Location.Text != "")
            {
                count++;
            }
            else
            {
                lbl_LocationWarning.Show();
            }
            if (txt_Password.Text != "")
            {
                count++;
            }
            else
            {
                lbl_PasswordWarning.Show();
            }

            if (count == 7)
            {
                btnAdd.Enabled = true;
            }
            else
            {
                btnAdd.Enabled = false;
            }
        }
    } 
}
