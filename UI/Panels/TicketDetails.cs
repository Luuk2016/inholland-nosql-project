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
        }

        public void LoadDetails(TicketModel ticket)
        {
            _ticket = ticket;
            lblDateTimeDetail.Text = _ticket.DateTimeReported.ToString();
            lblSubjectDetail.Text = _ticket.Subject;
            lblTypeDetail.Text = _ticket.Type.ToString();
            lblUserDetail.Text = _ticket.User.firstName;
            lblPriorityDetail.Text = _ticket.Priority.ToString();
            lblDeadlineDetail.Text = _ticket.Deadline.ToString();
            txtbDescription.Text = _ticket.Description;
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
    }
}
