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
        public void DeleteTicket(string id)
        {
            DeleteRecordById<TicketModel>("tickets", id);
        }

        public void CreateTicket(TicketModel ticket)
        {
            InsertRecord("tickets", ticket);
        }

        public TicketModel GetTicketById(string id)
        {
            return GetRecordById<TicketModel>("tickets", id);
        }

        public List<TicketModel> GetTickets()
        {
            return GetTable<TicketModel>("tickets");
        }

        public void UpdateTicket(TicketModel ticket)
        {
            UpdateRecord<TicketModel>("tickets", ticket.id.ToString(), ticket);
        }
    }
}
