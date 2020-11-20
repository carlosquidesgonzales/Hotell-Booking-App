using HotellbookingEF.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotellbookingEF.Data.Context
{
    public partial class SqlServerContext : DbContext
    {
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<RoomSize> Roomsizes { get; set; }
        public virtual DbSet<Booking> Bookings { get; set; }
        public virtual DbSet<Room> Rooms { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>()
                .HasMany(e => e.Bookings)
                .WithRequired(e => e.Customer)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<RoomSize>()
                .HasMany(e => e.Rooms)
                .WithRequired(e => e.RoomSize)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Booking>()
                .Property(e => e.cost)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Room>()
                .Property(e => e.Price)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Room>()
                .HasMany(e => e.Bookings)
                .WithRequired(e => e.Room)
                .WillCascadeOnDelete(false);
        }
    }
}
