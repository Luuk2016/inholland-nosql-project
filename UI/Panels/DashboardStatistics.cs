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
    public partial class DashboardStatistics : BaseForm
    {
        public EventHandler btnShowListClick;

        public DashboardStatistics()
        {
            InitializeComponent();
        }

        private void btnShowList_Click(object sender, EventArgs e)
        {
            btnShowListClick?.Invoke(sender, e);
        }
    }
}
