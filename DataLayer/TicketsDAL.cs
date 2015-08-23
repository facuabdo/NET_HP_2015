using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace DataLayer
{
    public class TicketsDAL
    {
        public IList<Tickets> getAllTickets()
        {
            TEVEntityModel db = new TEVEntityModel();
            return db.Tickets.ToList();
        }

        public Tickets getTicketById(Guid id)
        {
            TEVEntityModel db = new TEVEntityModel();
            return db.Tickets.Find(id);
        }

        public void createTicket(Tickets ticket)
        {
            TEVEntityModel db = new TEVEntityModel();
            db.Tickets.Add(ticket);
            db.SaveChanges();
        }

        public void updateTicket(Tickets ticket)
        {
            TEVEntityModel db = new TEVEntityModel();
            db.Entry<Tickets>(ticket).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
        }

        public void deleteTicket(Guid id)
        {
            TEVEntityModel db = new TEVEntityModel();
            db.Tickets.Remove(db.Tickets.Find(id));
            db.SaveChanges();
        }
    }
}
