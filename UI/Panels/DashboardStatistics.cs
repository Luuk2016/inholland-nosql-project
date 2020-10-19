using System;
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
