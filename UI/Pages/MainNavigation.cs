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
using UI.Panels;

namespace UI.Pages
{
    public partial class MainNavigation : BaseForm
    {
        DashboardStatistics dashboardStatisticsPartial = new DashboardStatistics();
        ManageUsers manageUsersPartial = new ManageUsers();
        TicketOverview ticketOverviewPartial = new TicketOverview();
        AddUser addUserPartial = new AddUser();
        AddIncidentTicket addIncidentTicketPartial = new AddIncidentTicket();

        protected override List<BaseForm> FormPartials { get; set; }
        protected override TableLayoutPanel TableLayoutPanel { get; set; }

        public MainNavigation()
        {
            InitializeComponent();

            TableLayoutPanel = pageLayoutContent;

            FormPartials = new List<BaseForm>();
            FormPartials.Add(manageUsersPartial);
            FormPartials.Add(ticketOverviewPartial);
            FormPartials.Add(dashboardStatisticsPartial);
            FormPartials.Add(addUserPartial);
            FormPartials.Add(addIncidentTicketPartial);

            dashboardStatisticsPartial.btnShowListClick += HandleDashboardShowListClick;

            ticketOverviewPartial.btnCreateTicketClick += HandleCreateTicketClick;
            addIncidentTicketPartial.btnCancelClick += HandleIncidentTicketCancelClick;

            manageUsersPartial.btnAddUserClick += HandleAddUserClick;
            addUserPartial.btnCancelClick += HandleAddUserCancelClick;

            LoadPanels();
        }

        //dashboard
        private void btnDashboard_Click(object sender, EventArgs e)
        {
            ShowPanel(dashboardStatisticsPartial);
        }

        private void HandleDashboardShowListClick(object sender, EventArgs e)
        {
            ShowPanel(ticketOverviewPartial);
        }

        //ticketmanagement
        private void btnIncidentManagement_Click(object sender, EventArgs e)
        {
            ShowPanel(ticketOverviewPartial);
        }

        private void HandleCreateTicketClick(object sender, EventArgs e)
        {
            ShowPanel(addIncidentTicketPartial);
        }

        private void HandleIncidentTicketCancelClick(object sender, EventArgs e)
        {
            ShowPanel(ticketOverviewPartial);
        }

        //usermanagement
        private void btnUserManagement_Click(object sender, EventArgs e)
        {
            ShowPanel(manageUsersPartial);
        }

        private void HandleAddUserClick(object sender, EventArgs e)
        {
            ShowPanel(addUserPartial);
        }

        private void HandleAddUserCancelClick(object sender, EventArgs e)
        {
            ShowPanel(manageUsersPartial);
        }
    }
}
