using System;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using Entities;

namespace DataLayer
{
    public partial class TEVEntityModel : DbContext
    {
        public TEVEntityModel()
            : base("name=TEVEntityModel")
        {
        }

        public virtual DbSet<Events> Events { get; set; }
        public virtual DbSet<EventTicketTypes> EventTicketTypes { get; set; }
        public virtual DbSet<Sales> Sales { get; set; }
        //public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<Tickets> Tickets { get; set; }
        public virtual DbSet<TicketTypes> TicketTypes { get; set; }
        public virtual DbSet<Users> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Events>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<Events>()
                .Property(e => e.description)
                .IsUnicode(false);

            modelBuilder.Entity<Events>()
                .HasMany(e => e.EventTicketTypes)
                .WithRequired(e => e.Events)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EventTicketTypes>()
                .HasMany(e => e.Tickets)
                .WithRequired(e => e.EventTicketTypes)
                .HasForeignKey(e => new { e.ticketTypeId, e.eventId })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Sales>()
                .HasMany(e => e.Tickets)
                .WithRequired(e => e.Sales)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Tickets>()
                .Property(e => e.accessCode)
                .IsUnicode(false);

            modelBuilder.Entity<Tickets>()
                .Property(e => e.state)
                .IsUnicode(false);

            modelBuilder.Entity<TicketTypes>()
                .Property(e => e.description)
                .IsUnicode(false);

            modelBuilder.Entity<TicketTypes>()
                .HasMany(e => e.EventTicketTypes)
                .WithRequired(e => e.TicketTypes)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Users>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<Users>()
                .Property(e => e.lastName)
                .IsUnicode(false);

            modelBuilder.Entity<Users>()
                .Property(e => e.email)
                .IsUnicode(false);

            modelBuilder.Entity<Users>()
                .Property(e => e.password)
                .IsUnicode(false);

            modelBuilder.Entity<Users>()
                .Property(e => e.phone)
                .IsUnicode(false);

            modelBuilder.Entity<Users>()
                .Property(e => e.dni)
                .IsUnicode(false);

            modelBuilder.Entity<Users>()
                .HasMany(e => e.Sales)
                .WithRequired(e => e.Users)
                .WillCascadeOnDelete(false);
        }
    }
}
