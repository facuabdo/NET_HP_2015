using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using DataLayer;

namespace BusinessLayer
{
    public class TicketTypesBL
    {
        public IList<TicketTypes> getAllTicketTypes()
        {
            return (new TicketTypesDAL()).getAllTicketTypes();
        }

        public TicketTypes getTicketTypeById(Guid id)
        {
            return (new TicketTypesDAL()).getTicketTypeById(id);
        }

        public void createTicketType(TicketTypes ticketType)
        {
            (new TicketTypesDAL()).createTicketType(ticketType);
        }

        public void updateTicketType(TicketTypes ticketType)
        {
            (new TicketTypesDAL()).updateTicketType(ticketType);
        }

        public void deleteTicketType(Guid id)
        {
            (new TicketTypesDAL()).deleteTicketType(id);
        }
    }
}
