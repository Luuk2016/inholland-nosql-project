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
    public partial class TicketOverview : BaseForm
    {
        public EventHandler btnCreateTicketClick;
        public TicketOverview()
        {
            InitializeComponent();
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
    }
}
