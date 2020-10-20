using System;
using System.Collections.Generic;
using System.Windows.Forms;
using UI.GlobalPage;
using Service;
using Model;
using Model.Enums;
using OtherFunctions;

namespace UI.Panels
{
    public partial class TicketDetails : BaseForm
    {
        public EventHandler btnResolveTicketClick;
        public EventHandler btnCancelClick;
        public EventHandler btnDeleteClick;
        
        private TicketService tService;
        private TicketModel _ticket;

        private UserService uService;

        public TicketDetails()
        {
            InitializeComponent();

            tService = new TicketService();
            uService = new UserService();

            btnCancelEdit.Hide();
            btnConfirm.Hide();
        }

        private void LoadUsers()
        {
            cmbUser.Items.Clear();
            List<UserModel> users = uService.GetUsers();

            foreach(var user in users)
            {
                cmbUser.Items.Add(user.firstName);
            }
        }

        public void LoadDetails(TicketModel ticket)
        {
            _ticket = ticket;
            cmbDate.Text = _ticket.DateTimeReported.ToString();
            txtbSubject.Text = _ticket.Subject;
            cmbType.Text = _ticket.Type.ToString();
            cmbUser.Text = _ticket.User.firstName;
            cmbPriority.Text = _ticket.Priority.ToString();
            cmbDeadline.Text = _ticket.Deadline.ToString();
            txtbDescription.Text = _ticket.Description;

            LoadUsers();

            cmbDate.Enabled = false;
            txtbSubject.Enabled = false;
            cmbType.Enabled = false;
            cmbUser.Enabled = false;
            cmbPriority.Enabled = false;
            cmbDeadline.Enabled = false;
            txtbDescription.Enabled = false;

            if (_ticket.Status == "resolved")
            {
                btnResolved.Enabled = false;
            }
        }

        private void btnResolved_Click(object sender, EventArgs e)
        {
            _ticket.Status = "resolved";
            tService.UpdateTicket(_ticket);
            btnResolveTicketClick?.Invoke(sender, e);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            btnCancelClick?.Invoke(sender, e);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            cmbType.Enabled = true;
            cmbUser.Enabled = true;
            cmbPriority.Enabled = true;
            cmbDeadline.Enabled = true;
            txtbDescription.Enabled = true;

            btnConfirm.Show();
            btnCancelEdit.Show();

            btnCancel.Hide();
            btnResolved.Hide();
            btnDelete.Hide();
            btnEdit.Hide();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            List<UserModel> users = uService.GetUsers();

            switch (cmbType.SelectedIndex)
            {
                case 0: 
                    _ticket.Type = TicketType.software;
                    break;
                case 1:
                    _ticket.Type = TicketType.hardware;
                    break;
                case 2:
                    _ticket.Type = TicketType.service;
                    break;
            }

            foreach (var user in users)
            {
                if (user.firstName == cmbUser.Text)
                {
                    _ticket.User = user;
                    _ticket.userID = user.id.ToString();
                    break;
                }
                else
                {
                    _ticket.User = Session.user;
                    _ticket.userID = Session.user.id.ToString();
                }
            }

            switch (cmbPriority.SelectedIndex)
            {
                case 0:
                    _ticket.Priority = TicketPriority.low;
                    break;
                case 1:
                    _ticket.Priority = TicketPriority.normal;
                    break;
                case 2:
                    _ticket.Priority = TicketPriority.high;
                    break;
            }

            switch (cmbDeadline.SelectedIndex)
            {
                case 0:
                    _ticket.Deadline = _ticket.DateTimeReported.AddDays(7);
                    break;
                case 1:
                    _ticket.Deadline = _ticket.DateTimeReported.AddDays(14);
                    break;
                case 2:
                    _ticket.Deadline = _ticket.DateTimeReported.AddDays(28);
                    break;
                case 3:
                    _ticket.Deadline = _ticket.DateTimeReported.AddMonths(6);
                    break;
            }

            _ticket.Description = txtbDescription.Text;

            btnCancelEdit.Hide();
            btnConfirm.Hide();

            btnCancel.Show();
            btnResolved.Show();
            btnDelete.Show();
            btnEdit.Show();

            tService.UpdateTicket(_ticket);

            LoadDetails(_ticket);
        }

        private void btnCancelEdit_Click(object sender, EventArgs e)
        {
            LoadDetails(_ticket);

            btnCancelEdit.Hide();
            btnConfirm.Hide();

            btnCancel.Show();
            btnResolved.Show();
            btnDelete.Show();
            btnEdit.Show();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            tService.DeleteTicket(_ticket.id.ToString());
            MessageBox.Show("Ticket " + _ticket.id.ToString() + " successfully deleted.", "Operation successfull", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnDeleteClick?.Invoke(sender, e);
        }
    }
}
