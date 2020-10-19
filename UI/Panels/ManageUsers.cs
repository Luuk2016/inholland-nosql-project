﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;
using UI.GlobalPage;
using Model;
using Service;

namespace UI.Pages
{
    public partial class ManageUsers : BaseForm
    {
        public EventHandler btnAddUserClick;
        private UserService uService;
        

        public ManageUsers()
        {
            InitializeComponent();

            uService = new UserService();

            LoadUsersFromDB();
        }

        private void LoadUsersFromDB()
        {
            List<UserModel> users = uService.GetUsers();

            lvUsers.Items.Clear();

            foreach (UserModel user in users)
            {
                ListViewItem lvi = new ListViewItem(user.id.ToString());
                lvi.SubItems.Add(user.email);
                lvi.SubItems.Add(user.firstName);
                lvi.SubItems.Add(user.lastName);
                lvi.SubItems.Add("#");
                lvUsers.Items.Add(lvi);
            }
        }

        private void txtbEmailFilter_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtbEmailFilter.Text != "")
                {
                    lvUsers.Items.Clear();

                    string searchEmail = txtbEmailFilter.Text;

                    UserModel user = uService.GetUserByEmail(searchEmail);

                    if (user != null)
                    {
                        ListViewItem lvi = new ListViewItem(user.id.ToString());
                        lvi.SubItems.Add(user.email);
                        lvi.SubItems.Add(user.firstName);
                        lvi.SubItems.Add(user.lastName);
                        lvi.SubItems.Add("#");
                        lvUsers.Items.Add(lvi);
                    }
                }
                else
                {
                    LoadUsersFromDB();
                }
            }
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            btnAddUserClick?.Invoke(sender, e);
        }

        private void txtbEmailFilter_MouseClick(object sender, MouseEventArgs e)
        {
            txtbEmailFilter.Clear();
        }
    }
}
