using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using DataLayer;

namespace BusinessLayer
{
    public class EventsBL
    {
        public IList<Events> getAllEvents()
        {
            return (new EventsDAL()).getAllEvents();
        }

        public Events getEventById(Guid id)
        {
            return (new EventsDAL()).getEventById(id);
        }

        public void createEvent(Events events)
        {
            (new EventsDAL()).createEvent(events);
        }

        public void updateEvent(Events events)
        {
            (new EventsDAL()).updateEvent(events);
        }

        public void deleteEvent(Guid id)
        {
            (new EventsDAL()).deleteEvent(id);
        }
    }
}
