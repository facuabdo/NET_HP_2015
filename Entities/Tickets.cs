using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
//using System.Data.Entity.Spatial;

namespace Entities
{
    public partial class Tickets
    {
        [Key]
        public Guid ticketId { get; set; }

        [Required]
        [StringLength(50)]
        public string accessCode { get; set; }

        [Required]
        [StringLength(50)]
        public string state { get; set; }

        public Guid saleId { get; set; }

        public Guid ticketTypeId { get; set; }

        public Guid eventId { get; set; }

        public virtual EventTicketTypes EventTicketTypes { get; set; }

        public virtual Sales Sales { get; set; }
    }
}
