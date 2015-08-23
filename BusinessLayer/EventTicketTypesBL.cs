using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;
using Entities;
namespace BusinessLayer
{
    public class EventTicketTypesBL
    {
        public IList<EventTicketTypes> getAllEventTicketTypes()
        {
            return (new EventTicketTypesDAL()).getAllEventTicketTypes();
        }

        public EventTicketTypes getEventTicketTypeByIds(Guid idTicketType, Guid idEvent)
        {
            return (new EventTicketTypesDAL()).getEventTicketTypesByIds(idTicketType,idEvent);
        }

        public void createEventTicketType(EventTicketTypes eventTicketType)
        {
            (new EventTicketTypesDAL()).createEventTicketType(eventTicketType);
        }

        public void updateEventTicketType(EventTicketTypes eventTicketType)
        {
            (new EventTicketTypesDAL()).updateEventTicketType(eventTicketType);
        }

        public void deleteEventTicketType(Guid idTicketType, Guid idEvent)
        {
            (new EventTicketTypesDAL()).deleteEventTicketType(idTicketType,idEvent);
        }
    }
}
