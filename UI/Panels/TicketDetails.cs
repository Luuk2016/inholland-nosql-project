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
        
        private TicketService ticketService = new TicketService();
        private TicketModel _ticket;
        public TicketDetails()
        {
            InitializeComponent();
            btnCancelEdit.Hide();
            btnConfirm.Hide();
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

            cmbDate.Enabled = false;
            txtbSubject.Enabled = false;
            cmbType.Enabled = false;
            cmbUser.Enabled = false;
            cmbPriority.Enabled = false;
            cmbDeadline.Enabled = false;
            txtbDescription.Enabled = false;
        }

        private void btnResolved_Click(object sender, EventArgs e)
        {
            _ticket.Status = "resolved";
            ticketService.UpdateTicket(_ticket);
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
            switch (cmbType.SelectedItem)
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
            _ticket.User = Session.user;
            switch (cmbPriority.SelectedItem)
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
            switch (cmbDeadline.SelectedItem)
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

            ticketService.UpdateTicket(_ticket);

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
            ticketService.DeleteTicket(_ticket.id.ToString());
            MessageBox.Show("Ticket " + _ticket.id.ToString() + "successfully deleted.", "Operation successfull", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
