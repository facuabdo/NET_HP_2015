using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace DataLayer
{
    public class EventsDAL
    {
        public IList<Events> getAllEvents()
        {
            TEVEntityModel db = new TEVEntityModel();
            return db.Events.ToList();
        }

        public Events getEventById(Guid id)
        {
            TEVEntityModel db = new TEVEntityModel();
            return db.Events.Find(id);
        }

        public void createEvent(Events events)
        {
            TEVEntityModel db = new TEVEntityModel();
            db.Events.Add(events);
            db.SaveChanges();
        }

        public void updateEvent(Events events)
        {
            TEVEntityModel db = new TEVEntityModel();
            db.Entry<Events>(events).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
        }

        public void deleteEvent(Guid id)
        {
            TEVEntityModel db = new TEVEntityModel();
            db.Events.Remove(db.Events.Find(id));
            db.SaveChanges();
        }
    }
}
