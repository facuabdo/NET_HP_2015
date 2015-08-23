using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using DataLayer;

namespace BusinessLayer
{
    public class TicketsBL
    {
        public IList<Tickets> getAllTickets()
        {
            return (new TicketsDAL()).getAllTickets();
        }

        public Tickets getTicketById(Guid id)
        {
            return (new TicketsDAL()).getTicketById(id);
        }

        public void createTicket(Tickets ticket)
        {
            (new TicketsDAL()).createTicket(ticket);
        }

        public void updateTicket(Tickets ticket)
        {
            (new TicketsDAL()).updateTicket(ticket);
        }

        public void deleteTicket(Guid id)
        {
            (new TicketsDAL()).deleteTicket(id);
        }
    }
}
