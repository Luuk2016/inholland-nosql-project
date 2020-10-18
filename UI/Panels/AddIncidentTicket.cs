using Model;
using Model.Enums;
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

namespace UI.Pages
{
    public partial class AddIncidentTicket : BaseForm
    {
        public EventHandler btnCancelClick;
        public EventHandler btnSubmitClick;
        private TicketService ticketService;
        UserModel user = new UserModel();
        public AddIncidentTicket()
        {
            InitializeComponent();
            LoadBasics();
            ticketService = new TicketService();
        }

        private void LoadBasics()
        {
            cmbDate.Text = DateTime.Now.ToString();
            //cmbUser.Text = 
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (cmbDate.Text != "" && txtbSubject.Text != "" && cmbType.Text != "" && cmbUser.Text != "" && cmbPriority.Text != "" && cmbDeadline.Text != "" && txtbDescription.Text != "")
            {
                TicketModel ticket = new TicketModel();

                ticket.DateTimeReported = DateTime.Now;
                ticket.Subject = txtbSubject.Text;
                switch (cmbType.SelectedItem)
                {
                    case 0:
                        ticket.Type = TicketType.software;
                        break;
                    case 1:
                        ticket.Type = TicketType.hardware;
                        break;
                    case 2:
                        ticket.Type = TicketType.service;
                        break;
                }
                //maybe change later
                ticket.User.firstName = cmbUser.Text;
                switch (cmbPriority.SelectedItem)
                {
                    case 0:
                        ticket.Priority = TicketPriority.low;
                        break;
                    case 1:
                        ticket.Priority = TicketPriority.normal;
                        break;
                    case 2:
                        ticket.Priority = TicketPriority.high;
                        break;
                }
                switch (cmbDeadline.SelectedItem)
                {
                    case 0:
                        ticket.Deadline = ticket.DateTimeReported.AddDays(7);
                        break;
                    case 1:
                        ticket.Deadline = ticket.DateTimeReported.AddDays(14);
                        break;
                    case 2:
                        ticket.Deadline = ticket.DateTimeReported.AddDays(28);
                        break;
                    case 3:
                        ticket.Deadline = ticket.DateTimeReported.AddMonths(6);
                        break;
                }
                ticket.Description = txtbDescription.Text;
                ticket.Status = "unresolved";

                ticketService.CreateTicket(ticket);

                MessageBox.Show("The ticket has been created!", "Operation successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

                btnSubmitClick?.Invoke(sender, e);
            }
            else
            {
                MessageBox.Show("Not all fields are filled in", "Action failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            btnCancelClick?.Invoke(sender, e);
        }
    }
}
