using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
//using System.Data.Entity.Spatial;

namespace Entities
{
    public partial class Users
    {
        public Users()
        {
            Sales = new HashSet<Sales>();
        }

        [Key]
        public Guid userId { get; set; }

        [Required]
        [StringLength(50)]
        public string name { get; set; }

        [Required]
        [StringLength(50)]
        public string lastName { get; set; }

        [Required]
        [StringLength(50)]
        public string email { get; set; }

        [Required]
        [StringLength(50)]
        public string password { get; set; }

        [Required]
        [StringLength(50)]
        public string phone { get; set; }

        [Required]
        [StringLength(50)]
        public string dni { get; set; }

        public DateTime creationDate { get; set; }

        public virtual ICollection<Sales> Sales { get; set; }
    }
}
