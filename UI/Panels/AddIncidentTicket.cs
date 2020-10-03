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
        public AddIncidentTicket()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            btnCancelClick?.Invoke(sender, e);
        }
    }
}
