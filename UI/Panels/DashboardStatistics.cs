using Model;
using Service;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using UI.GlobalPage;

namespace UI.Pages
{
    public partial class DashboardStatistics : BaseForm
    {
        public EventHandler btnShowListClick;

        private TicketService tService;

        private List<TicketModel> tickets;
        private int amountOfTickets;

        public DashboardStatistics()
        {
            InitializeComponent();

            // Initialize the ticketService 
            tService = new TicketService();

            // Get all the tickets
            tickets = tService.GetTickets();

            // Get the amount of tickets that are in the DB
            amountOfTickets = tickets.Count;
            
            // Load the Unresolved/Resolved chart
            LoadResolvedUnresolvedChart();

            // Load the PastDeadline chart
            LoadPastDeadlineChart();
        }

        private void btnShowList_Click(object sender, EventArgs e)
        {
            btnShowListClick?.Invoke(sender, e);
        }

        private void LoadResolvedUnresolvedChart()
        {
            chResolvedUnresolvedTickets.Series["unresolved-resolved-tickets"].IsValueShownAsLabel = true;

            // The amount of tickets that are unresolved
            int unresolvedTickets = GetAmountOfUnresolvedTickets();
            int resolvedTickets = amountOfTickets - unresolvedTickets;

            // Put the data in the chart
            chResolvedUnresolvedTickets.Series["unresolved-resolved-tickets"].Points.AddXY("Unresolved", unresolvedTickets.ToString());
            chResolvedUnresolvedTickets.Series["unresolved-resolved-tickets"].Points.AddXY("Resolved", resolvedTickets.ToString());
        }

        private void LoadPastDeadlineChart()
        {
            chPastDeadline.Series["pastDeadline"].IsValueShownAsLabel = true;

            // The amount of tickets that are past the deadline
            int ticketsPastDeadline = GetAmountOfTicketsPastDeadline();
            int ticketsOnTime = amountOfTickets - ticketsPastDeadline;

            // Put the data in the chart
            chPastDeadline.Series["pastDeadline"].Points.AddXY("Past deadline", ticketsPastDeadline.ToString());
            chPastDeadline.Series["pastDeadline"].Points.AddXY("On time", ticketsOnTime.ToString());
        }

        private int GetAmountOfUnresolvedTickets()
        {
            int resolved = 0;

            foreach (TicketModel t in tickets)
            {
                if (t.Status == "unresolved")
                {
                    resolved++;
                }
            }

            return resolved;
        }

        private int GetAmountOfTicketsPastDeadline()
        {
            int pastDeadline = 0;

            foreach (TicketModel t in tickets)
            {
                if (t.Deadline < DateTime.Now)
                {
                    pastDeadline++;
                }
            }

            return pastDeadline;
        }
    }
}
