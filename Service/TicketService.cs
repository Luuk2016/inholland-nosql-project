using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Model;

namespace Service
{
    public class TicketService
    {
        private TicketDAO ticketDAO;

        public TicketService()
        {
            ticketDAO = new TicketDAO();
        }

        public void CreateTicket(TicketModel ticket)
        {
            ticketDAO.CreateTicket(ticket);
        }

        public List<TicketModel> GetTickets()
        {
            return ticketDAO.GetTickets();
        }

        public TicketModel GetTicketById(string id)
        {
            return ticketDAO.GetTicketById(id);
        }

        //public void UpdateTicket(TicketModel ticket)
        //{
        //    ticketDAO.UpdateTicket(ticket);
        //}

        public void DeleteTicket(string id)
        {
            ticketDAO.DeleteTicket(id);
        }
    }
}
