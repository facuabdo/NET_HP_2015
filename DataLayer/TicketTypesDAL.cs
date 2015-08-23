using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace DataLayer
{
    public class TicketTypesDAL
    {
        public IList<TicketTypes> getAllTicketTypes()
        {
            TEVEntityModel db = new TEVEntityModel();
            return db.TicketTypes.ToList();
        }

        public TicketTypes getTicketTypeById(Guid id)
        {
            TEVEntityModel db = new TEVEntityModel();
            return db.TicketTypes.Find(id);
        }

        public void createTicketType(TicketTypes ticketType)
        {
            TEVEntityModel db = new TEVEntityModel();
            db.TicketTypes.Add(ticketType);
            db.SaveChanges();
        }

        public void updateTicketType(TicketTypes ticketType)
        {
            TEVEntityModel db = new TEVEntityModel();
            db.Entry<TicketTypes>(ticketType).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
        }

        public void deleteTicketType(Guid id)
        {
            TEVEntityModel db = new TEVEntityModel();
            db.TicketTypes.Remove(db.TicketTypes.Find(id));
            db.SaveChanges();
        }
    }
}
