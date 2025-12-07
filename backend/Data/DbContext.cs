using backend.Model;
using Microsoft.EntityFrameworkCore;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    public DbSet<Booking> Workouts => Set<Booking>();
    public DbSet<Flight> Flight => Set<Flight>();
    public DbSet<Payment> Payment => Set<Payment>();
    public DbSet<User> User => Set<User>();
}