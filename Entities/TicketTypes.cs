using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
//using System.Data.Entity.Spatial;

namespace Entities
{
    public partial class TicketTypes
    {
        public TicketTypes()
        {
            EventTicketTypes = new HashSet<EventTicketTypes>();
        }

        [Key]
        public Guid ticketTypeId { get; set; }

        [Required]
        [StringLength(200)]
        public string description { get; set; }

        public virtual ICollection<EventTicketTypes> EventTicketTypes { get; set; }
    }
}
