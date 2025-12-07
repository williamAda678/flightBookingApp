using backend.Model;
using Microsoft.EntityFrameworkCore;

namespace FlightBookingApp.Data
{
    public class AppDbContext : DbContext
    {
        // This constructor is required for dependency injection
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        // DbSets for your models
        public DbSet<User> Users { get; set; }
        public DbSet<Flight> Flights { get; set; }
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<Payment> Payments { get; set; }

        // Optional: override OnModelCreating if needed
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
