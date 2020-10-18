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

namespace UI.Pages
{
    public partial class TicketOverview : BaseForm
    {
        public EventHandler btnCreateTicketClick;
        public EventHandler ShowTicketDetails;
        TicketService ticketService = new TicketService();

        public TicketOverview()
        {
            InitializeComponent();
            LoadLvTickets();
        }

        private void btnCreateTicket_Click(object sender, EventArgs e)
        {
            btnCreateTicketClick?.Invoke(sender, e);
        }

        private void txtbEmailFilter_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtbEmailFilter_MouseClick(object sender, MouseEventArgs e)
        {
            txtbEmailFilter.Clear();
        }

        private void TicketOverview_VisibleChanged(object sender, EventArgs e)
        {
            LoadLvTickets();
            txtbEmailFilter.Text = "Filter by Email";
        }

        private void LoadLvTickets()
        {
            var tickets = ticketService.GetTickets();

            foreach (var ticket in tickets)
            {
                ListViewItem item = new ListViewItem(ticket.id.ToString());
                item.SubItems.Add(ticket.Subject);
                item.SubItems.Add(ticket.User.firstName);
                item.SubItems.Add(ticket.DateTimeReported.ToString());
                item.SubItems.Add(ticket.Status);

                lvTickets.Items.Add(item);
            }
        }

        private void lvTickets_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var id = lvTickets.SelectedItems[0].Text;
            TicketModel ticket = ticketService.GetTicketById(id);
            ticket = sender as TicketModel;
            ShowTicketDetails?.Invoke(sender, e);
        }
    }
}
