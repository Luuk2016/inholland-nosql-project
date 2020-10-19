using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace DAL
{
    public class TicketDAO : MongoBase
    {
        /*
         * Delete a ticket
         * @param string id - the id of the ticket
        */
        public void DeleteTicket(string id)
        {
            DeleteRecordById<TicketModel>("tickets", id);
        }

        /*
         * Create a ticket
         * @param TicketModel ticket - the ticket object
        */
        public void CreateTicket(TicketModel ticket)
        {
            InsertRecord("tickets", ticket);
        }

        /*
         * Get a ticket by it's ID
         * @param string id - the id of the ticket
         * @return TicketModel - the ticket
        */
        public TicketModel GetTicketById(string id)
        {
            return GetRecordById<TicketModel>("tickets", id);
        }

        /*
         * Get all tickets
         * @return List<TicketModel> - the tickets
        */
        public List<TicketModel> GetTickets()
        {
            return GetTable<TicketModel>("tickets");
        }

        /*
         * Update a ticket
         * @param TicketModel ticket - the ticket object
        */
        public void UpdateTicket(TicketModel ticket)
        {
            UpdateRecord<TicketModel>("tickets", ticket.id.ToString(), ticket);
        }
    }
}
