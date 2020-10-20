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
        }

        private void DashboardStatistics_VisibleChanged(object sender, EventArgs e)
        {
            // Get all the tickets
            tickets = tService.GetTickets();

            // Get the amount of tickets that are in the DB
            amountOfTickets = tickets.Count;

            // Load the Unresolved/Resolved chart
            LoadResolvedUnresolvedChart();

            // Load the PastDeadline chart
            LoadPastDeadlineChart();

            // Load the Category chart
            LoadCategoryChart();

            // Load the Priority chart
            LoadPriorityChart();
        }

        private void btnShowList_Click(object sender, EventArgs e)
        {
            btnShowListClick?.Invoke(sender, e);
        }

        private void LoadResolvedUnresolvedChart()
        {
            chResolvedUnresolvedTickets.Series["unresolved-resolved-tickets"].Points.Clear();

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
            chPastDeadline.Series["pastDeadline"].Points.Clear();

            chPastDeadline.Series["pastDeadline"].IsValueShownAsLabel = true;

            // The amount of tickets that are past the deadline
            int ticketsPastDeadline = GetAmountOfTicketsPastDeadline();
            int ticketsOnTime = amountOfTickets - ticketsPastDeadline;

            // Put the data in the chart
            chPastDeadline.Series["pastDeadline"].Points.AddXY("Past deadline", ticketsPastDeadline.ToString());
            chPastDeadline.Series["pastDeadline"].Points.AddXY("On time", ticketsOnTime.ToString());
        }

        private void LoadCategoryChart()
        {
            chCategories.Series["tickets-categories"].Points.Clear();

            chCategories.Series["tickets-categories"].IsValueShownAsLabel = true;

            var categories = GetAmountOfTicketsPerCategory();

            // Put the data in the chart
            chCategories.Series["tickets-categories"].Points.AddXY("Software", categories["software"].ToString());
            chCategories.Series["tickets-categories"].Points.AddXY("Hardware", categories["hardware"].ToString());
            chCategories.Series["tickets-categories"].Points.AddXY("Service", categories["service"].ToString());

        }

        private void LoadPriorityChart()
        {
            chPriorityLevels.Series["tickets-priority-levels"].Points.Clear();

            chPriorityLevels.Series["tickets-priority-levels"].IsValueShownAsLabel = true;

            var priorityLevels = GetAmountOfTicketsPerPriorityLevel();

            // Put the data in the chart
            chPriorityLevels.Series["tickets-priority-levels"].Points.AddXY("Low", priorityLevels["low"].ToString());
            chPriorityLevels.Series["tickets-priority-levels"].Points.AddXY("Medium", priorityLevels["normal"].ToString());
            chPriorityLevels.Series["tickets-priority-levels"].Points.AddXY("High", priorityLevels["high"].ToString());

        }

        private int GetAmountOfUnresolvedTickets()
        {
            int unresolved = 0;

            foreach (TicketModel t in tickets)
            {
                if (t.Status == "unresolved")
                {
                    unresolved++;
                }
            }

            return unresolved;
        }

        private int GetAmountOfTicketsPastDeadline()
        {
            int pastDeadline = 0;

            foreach (TicketModel t in tickets)
            {
                if (t.Deadline < DateTime.Now && t.Status == "unresolved")
                {
                    pastDeadline++;
                }
            }

            return pastDeadline;
        }

        private Dictionary<string,int> GetAmountOfTicketsPerCategory()
        {
            Dictionary<string, int> result = new Dictionary<string, int>();
            result["software"] = 0;
            result["hardware"] = 0;
            result["service"] = 0;

            foreach (TicketModel t in tickets)
            {
                switch (t.Type)
                {
                    case Model.Enums.TicketType.software:
                        result["software"]++;
                        break;
                    case Model.Enums.TicketType.hardware:
                        result["hardware"]++;
                        break;
                    case Model.Enums.TicketType.service:
                        result["service"]++;
                        break;
                }
            }

            return result;
        }

        private Dictionary<string, int> GetAmountOfTicketsPerPriorityLevel()
        {
            Dictionary<string, int> result = new Dictionary<string, int>();
            result["low"] = 0;
            result["normal"] = 0;
            result["high"] = 0;

            foreach (TicketModel t in tickets)
            {
                switch (t.Priority)
                {
                    case Model.Enums.TicketPriority.low:
                        result["low"]++;
                        break;
                    case Model.Enums.TicketPriority.normal:
                        result["normal"]++;
                        break;
                    case Model.Enums.TicketPriority.high:
                        result["high"]++;
                        break;
                }
            }

            return result;
        }
    }
}
