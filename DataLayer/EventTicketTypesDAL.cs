using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace DataLayer
{
    public class EventTicketTypesDAL
    {
        public IList<EventTicketTypes> getAllEventTicketTypes()
        {
            TEVEntityModel db = new TEVEntityModel();
            return db.EventTicketTypes.ToList();
        }

        public EventTicketTypes getEventTicketTypesByIds(Guid idTicketType, Guid idEvent)
        {
            TEVEntityModel db = new TEVEntityModel();
            return db.EventTicketTypes.Find(idTicketType, idEvent);
        }

        public void createEventTicketType(EventTicketTypes eventTicketType)
        {
            TEVEntityModel db = new TEVEntityModel();
            db.EventTicketTypes.Add(eventTicketType);
            db.SaveChanges();
        }

        public void updateEventTicketType(EventTicketTypes eventTicketType)
        {
            TEVEntityModel db = new TEVEntityModel();
            db.Entry<EventTicketTypes>(eventTicketType).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
        }

        public void deleteEventTicketType(Guid idTicketType, Guid idEvent)
        {
            TEVEntityModel db = new TEVEntityModel();
            db.EventTicketTypes.Remove(db.EventTicketTypes.Find(idTicketType, idEvent));
            db.SaveChanges();
        }
    }
}
