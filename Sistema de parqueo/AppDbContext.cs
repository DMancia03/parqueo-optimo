using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Sistema_de_parqueo
{
    public partial class AppDbContext : DbContext
    {
        public AppDbContext()
            : base("name=AppDbContext")
        {
        }

        public virtual DbSet<customer> customers { get; set; }
        public virtual DbSet<parking_lot> parking_lot { get; set; }
        public virtual DbSet<parking_slot> parking_slot { get; set; }
        public virtual DbSet<parking_slot_reservation> parking_slot_reservation { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<customer>()
                .Property(e => e.customer_name)
                .IsUnicode(false);

            modelBuilder.Entity<customer>()
                .Property(e => e.customer_lastname)
                .IsUnicode(false);

            modelBuilder.Entity<customer>()
                .Property(e => e.customer_DUI)
                .IsUnicode(false);

            modelBuilder.Entity<customer>()
                .Property(e => e.customer_password)
                .IsUnicode(false);

            modelBuilder.Entity<parking_lot>()
                .Property(e => e.is_parking_lot_full)
                .IsUnicode(false);

            modelBuilder.Entity<parking_lot>()
                .HasMany(e => e.parking_slot)
                .WithRequired(e => e.parking_lot)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<parking_slot>()
                .Property(e => e.is_parking_slot_free)
                .IsUnicode(false);

            modelBuilder.Entity<parking_slot>()
                .HasMany(e => e.parking_slot_reservation)
                .WithRequired(e => e.parking_slot)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<parking_slot_reservation>()
                .Property(e => e.customer_DUI)
                .IsUnicode(false);
        }
    }
}
