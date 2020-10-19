﻿using System;
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
using UI.Panels;

namespace UI.Pages
{
    public partial class TicketOverview : BaseForm
    {
        public EventHandler btnCreateTicketClick;
        public EventHandler ShowTicketDetails;
        public TicketModel ticket;
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

        private void txtbEmailFilter_MouseClick(object sender, MouseEventArgs e)
        {
            txtbEmailFilter.Clear();
        }

        private void TicketOverview_VisibleChanged(object sender, EventArgs e)
        {
            lvUnresolvedTickets.Items.Clear();
            LoadLvTickets();
            txtbEmailFilter.Text = "Filter by name";
        }

        private void LoadLvTickets()
        {
            var tickets = ticketService.GetTickets();

            foreach (var ticket in tickets)
            {
                if(ticket.Status == "unresolved")
                {
                    ListViewItem item = new ListViewItem(ticket.id.ToString());
                    item.SubItems.Add(ticket.Subject);
                    item.SubItems.Add(ticket.User.firstName);
                    item.SubItems.Add(ticket.DateTimeReported.ToString());
                    item.SubItems.Add(ticket.Status);

                    lvUnresolvedTickets.Items.Add(item);
                }
                else if(ticket.Status == "resolved")
                {
                    ListViewItem item = new ListViewItem(ticket.id.ToString());
                    item.SubItems.Add(ticket.Subject);
                    item.SubItems.Add(ticket.User.firstName);
                    item.SubItems.Add(ticket.DateTimeReported.ToString());
                    item.SubItems.Add(ticket.Status);

                    LvResovledTickets.Items.Add(item);
                }
                
            }
        }

        private void lvTickets_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if(lvUnresolvedTickets.SelectedItems[0].Text != null)
            {
                var id = lvUnresolvedTickets.SelectedItems[0].Text;
                ticket = ticketService.GetTicketById(id);
                ShowTicketDetails?.Invoke(sender, e);
            }
        }

        private void txtbEmailFilter_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if(txtbEmailFilter.Text != null || txtbEmailFilter.Text != " ")
                {
                    lvUnresolvedTickets.Items.Clear();
                    List<TicketModel> ticketList = ticketService.GetTickets();

                    foreach (var ticket in ticketList)
                    {
                        if (ticket.User.firstName.ToLower() == txtbEmailFilter.Text.ToLower())
                        {
                            ListViewItem item = new ListViewItem(ticket.id.ToString());
                            item.SubItems.Add(ticket.Subject);
                            item.SubItems.Add(ticket.User.firstName);
                            item.SubItems.Add(ticket.DateTimeReported.ToString());
                            item.SubItems.Add(ticket.Status);

                            lvUnresolvedTickets.Items.Add(item);
                        }
                    }
                }
                else
                {
                    LoadLvTickets();
                }
            }
        }

        private void LvResovledTickets_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (LvResovledTickets.SelectedItems[0].Text != null)
            {
                var id = LvResovledTickets.SelectedItems[0].Text;
                ticket = ticketService.GetTicketById(id);
                ShowTicketDetails?.Invoke(sender, e);
            }
        }
    }
}
