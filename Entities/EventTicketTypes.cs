using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
//using System.Data.Entity.Spatial;


namespace Entities
{
    public partial class EventTicketTypes
    {
        public EventTicketTypes()
        {
            Tickets = new HashSet<Tickets>();
        }

        [Key]
        [Column(Order = 0)]
        public Guid ticketTypeId { get; set; }

        [Key]
        [Column(Order = 1)]
        public Guid eventId { get; set; }

        public decimal price { get; set; }

        public int totalTickets { get; set; }

        public virtual Events Events { get; set; }

        public virtual TicketTypes TicketTypes { get; set; }

        public virtual ICollection<Tickets> Tickets { get; set; }
    }
}
