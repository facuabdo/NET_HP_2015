using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
//using System.Data.Entity.Spatial;

namespace Entities
{
    public partial class Sales
    {
        public Sales()
        {
            Tickets = new HashSet<Tickets>();
        }

        [Key]
        public Guid saleId { get; set; }

        public DateTime saleDateTime { get; set; }

        public Guid userId { get; set; }

        public virtual Users Users { get; set; }

        public virtual ICollection<Tickets> Tickets { get; set; }
    }
}
