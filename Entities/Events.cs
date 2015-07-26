using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
//using System.Data.Entity.Spatial;

namespace Entities
{
    public partial class Events
    {
        public Events()
        {
            EventTicketTypes = new HashSet<EventTicketTypes>();
        }

        [Key]
        public Guid eventId { get; set; }

        [Display(Name="Nombre",Description="Nombre del evento")]    
        [Required]
        [StringLength(200)]
        public string name { get; set; }

        [DataType(DataType.MultilineText)]
        [Display(Name="Descripcion",Description="Sinopsis del evento")]
        [Required]
        public string description { get; set; }

        [DataType(DataType.Date)]
        [Display(Name="Fecha de inicio")]
        public DateTime startDate { get; set; }

        [Range(0,99)]
        [Display(Name="Edad mínima ingreso")]
        public int minage { get; set; }

        public virtual ICollection<EventTicketTypes> EventTicketTypes { get; set; }
    }
}
