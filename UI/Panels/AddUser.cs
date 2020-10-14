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
        public AddUser()
        {
            InitializeComponent();
            uService = new UserService();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            UserModel user = new UserModel();
            user.firstName = txt_FirstName.Text;
            user.lastName = txt_LastName.Text;
            user.email = txt_Email.Text;
            user.location = cmb_Location.Text;
            user.phoneNumber = txt_PhoneNumber.Text;
            user.type = cmb_TypeUser.Text;
            uService.CreateUser(user);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            btnCancelClick?.Invoke(sender, e);
        }
    }
}
