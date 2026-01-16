using backend.Model;
using Microsoft.EntityFrameworkCore;

namespace FlightBookingApp.Data
{
    public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
    {

        // DbSets for your models
        public DbSet<Flight> Flights { get; set; }
        public DbSet<Aircraft> Aircraft { get; set; }
        public DbSet<Airport> Airport { get; set; }


        // Optional: override OnModelCreating if needed
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
