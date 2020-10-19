﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;
using UI.GlobalPage;
using UI.Panels;
using OtherFunctions;
using Model;
using Service;

namespace UI.Pages
{
    public partial class MainNavigation : BaseForm
    {
        DashboardStatistics dashboardStatisticsPartial = new DashboardStatistics();
        ManageUsers manageUsersPartial = new ManageUsers();
        TicketOverview ticketOverviewPartial = new TicketOverview();
        AddUser addUserPartial = new AddUser();
        AddIncidentTicket addIncidentTicketPartial = new AddIncidentTicket();
        TicketDetails ticketDetailsPartial = new TicketDetails();
        public EventHandler logoutHandler;

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
            FormPartials.Add(ticketDetailsPartial);

            //statistics dashboard
            dashboardStatisticsPartial.btnShowListClick += HandleDashboardShowListClick;

            //ticketmanagement
            ticketDetailsPartial.btnCancelClick += HandleIncidentTicketCancelClick;
            ticketDetailsPartial.btnResolveTicketClick += HandleResolveTicketClick;
            ticketDetailsPartial.btnDeleteClick += HandleDeleteTicketClick;
            ticketOverviewPartial.btnCreateTicketClick += HandleCreateTicketClick;
            ticketOverviewPartial.ShowTicketDetails += HandleShowTicketDetails;
            addIncidentTicketPartial.btnCancelClick += HandleIncidentTicketCancelClick;
            addIncidentTicketPartial.btnSubmitClick += HandleIncidentTicketSubmitClick;

            //usermanagement
            manageUsersPartial.btnAddUserClick += HandleAddUserClick;
            addUserPartial.btnCancelClick += HandleAddUserCancelClick;

            LoadPanels();
        }

        //statistics dashboard
        private void btnDashboard_Click(object sender, EventArgs e)
        {
            ShowPanel(dashboardStatisticsPartial);
        }

        private void HandleDashboardShowListClick(object sender, EventArgs e)
        {
            ShowPanel(ticketOverviewPartial);
        }

        //ticketmanagement
        private void HandleDeleteTicketClick(object sender, EventArgs e)
        {
            ShowPanel(ticketOverviewPartial);
        }

        private void HandleResolveTicketClick(object sender, EventArgs e)
        {
            ShowPanel(ticketOverviewPartial);
        }
        private void btnIncidentManagement_Click(object sender, EventArgs e)
        {
            ShowPanel(ticketOverviewPartial);
        }

        private void HandleCreateTicketClick(object sender, EventArgs e)
        {
            ShowPanel(addIncidentTicketPartial);
        }

        private void HandleShowTicketDetails(object sender, EventArgs e)
        {
            TicketModel ticket = new TicketModel();
            ticket = ticketOverviewPartial.ticket;
            ticketDetailsPartial.LoadDetails(ticket);
            ShowPanel(ticketDetailsPartial);
        }

        private void HandleIncidentTicketCancelClick(object sender, EventArgs e)
        {
            ShowPanel(ticketOverviewPartial);
        }

        private void HandleIncidentTicketSubmitClick(object sender, EventArgs e)
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

        //logout
        private void btnLogout_Click(object sender, EventArgs e)
        {
            // Wipe the current session
            Session.Wipe();

            logoutHandler?.Invoke(sender, e);
        }
    }
}
