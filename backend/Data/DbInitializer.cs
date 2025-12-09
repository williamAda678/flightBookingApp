using System;
using System.Collections.Generic;
using System.Linq;
using backend.Model;

namespace FlightBookingApp.Data
{
    public static class SeedData
    {
        public static void SeedFlights(AppDbContext context)
        {
            if (context.Flights.Any())
            {
                return; // Data already seeded
            }

            var flights = new List<Flight>
            {
                new Flight { Origin = "JFK", Destination = "LAX", DepartureTime = DateTime.UtcNow.AddDays(3).AddHours(9), ArrivalTime = DateTime.UtcNow.AddDays(3).AddHours(14), Airline = "Delta", Price = 299.99m, CabinClass = "Economy" },
                new Flight { Origin = "LAX", Destination = "ORD", DepartureTime = DateTime.UtcNow.AddDays(4).AddHours(15), ArrivalTime = DateTime.UtcNow.AddDays(4).AddHours(20), Airline = "United", Price = 350.00m, CabinClass = "Business" },
                new Flight { Origin = "ATL", Destination = "MIA", DepartureTime = DateTime.UtcNow.AddDays(2).AddHours(8), ArrivalTime = DateTime.UtcNow.AddDays(2).AddHours(10), Airline = "American", Price = 150.00m, CabinClass = "Economy" },
                new Flight { Origin = "ORD", Destination = "SEA", DepartureTime = DateTime.UtcNow.AddDays(5).AddHours(13), ArrivalTime = DateTime.UtcNow.AddDays(5).AddHours(17), Airline = "Alaska", Price = 400.00m, CabinClass = "Business" },
                new Flight { Origin = "DFW", Destination = "DEN", DepartureTime = DateTime.UtcNow.AddDays(1).AddHours(7), ArrivalTime = DateTime.UtcNow.AddDays(1).AddHours(9), Airline = "Spirit", Price = 120.00m, CabinClass = "Economy" },
                new Flight { Origin = "SFO", Destination = "LAS", DepartureTime = DateTime.UtcNow.AddDays(3).AddHours(12), ArrivalTime = DateTime.UtcNow.AddDays(3).AddHours(14), Airline = "Southwest", Price = 180.00m, CabinClass = "Economy" },
                new Flight { Origin = "MIA", Destination = "BOS", DepartureTime = DateTime.UtcNow.AddDays(6).AddHours(9), ArrivalTime = DateTime.UtcNow.AddDays(6).AddHours(12), Airline = "JetBlue", Price = 220.00m, CabinClass = "Economy" },
                new Flight { Origin = "BOS", Destination = "JFK", DepartureTime = DateTime.UtcNow.AddDays(2).AddHours(11), ArrivalTime = DateTime.UtcNow.AddDays(2).AddHours(12), Airline = "Delta", Price = 110.00m, CabinClass = "Economy" },
                new Flight { Origin = "SEA", Destination = "SFO", DepartureTime = DateTime.UtcNow.AddDays(4).AddHours(10), ArrivalTime = DateTime.UtcNow.AddDays(4).AddHours(12), Airline = "Alaska", Price = 200.00m, CabinClass = "Business" },
                new Flight { Origin = "LAX", Destination = "ATL", DepartureTime = DateTime.UtcNow.AddDays(3).AddHours(14), ArrivalTime = DateTime.UtcNow.AddDays(3).AddHours(22), Airline = "Delta", Price = 320.00m, CabinClass = "Economy" },
                new Flight { Origin = "ORD", Destination = "MIA", DepartureTime = DateTime.UtcNow.AddDays(5).AddHours(9), ArrivalTime = DateTime.UtcNow.AddDays(5).AddHours(14), Airline = "American", Price = 280.00m, CabinClass = "Economy" },
                new Flight { Origin = "DFW", Destination = "LAX", DepartureTime = DateTime.UtcNow.AddDays(1).AddHours(16), ArrivalTime = DateTime.UtcNow.AddDays(1).AddHours(19), Airline = "Southwest", Price = 250.00m, CabinClass = "Business" },
                new Flight { Origin = "MIA", Destination = "ORD", DepartureTime = DateTime.UtcNow.AddDays(2).AddHours(7), ArrivalTime = DateTime.UtcNow.AddDays(2).AddHours(11), Airline = "United", Price = 260.00m, CabinClass = "Economy" },
                new Flight { Origin = "SFO", Destination = "SEA", DepartureTime = DateTime.UtcNow.AddDays(3).AddHours(13), ArrivalTime = DateTime.UtcNow.AddDays(3).AddHours(15), Airline = "Alaska", Price = 190.00m, CabinClass = "Economy" },
                new Flight { Origin = "JFK", Destination = "MIA", DepartureTime = DateTime.UtcNow.AddDays(4).AddHours(10), ArrivalTime = DateTime.UtcNow.AddDays(4).AddHours(14), Airline = "JetBlue", Price = 270.00m, CabinClass = "Business" },
                new Flight { Origin = "LAX", Destination = "SFO", DepartureTime = DateTime.UtcNow.AddDays(1).AddHours(8), ArrivalTime = DateTime.UtcNow.AddDays(1).AddHours(9), Airline = "Southwest", Price = 120.00m, CabinClass = "Economy" },
                new Flight { Origin = "ATL", Destination = "DFW", DepartureTime = DateTime.UtcNow.AddDays(2).AddHours(15), ArrivalTime = DateTime.UtcNow.AddDays(2).AddHours(18), Airline = "Spirit", Price = 140.00m, CabinClass = "Economy" },
                new Flight { Origin = "SEA", Destination = "ORD", DepartureTime = DateTime.UtcNow.AddDays(5).AddHours(12), ArrivalTime = DateTime.UtcNow.AddDays(5).AddHours(18), Airline = "United", Price = 310.00m, CabinClass = "Business" },
                new Flight { Origin = "BOS", Destination = "MIA", DepartureTime = DateTime.UtcNow.AddDays(3).AddHours(6), ArrivalTime = DateTime.UtcNow.AddDays(3).AddHours(10), Airline = "American", Price = 230.00m, CabinClass = "Economy" },
                new Flight { Origin = "JFK", Destination = "SEA", DepartureTime = DateTime.UtcNow.AddDays(6).AddHours(9), ArrivalTime = DateTime.UtcNow.AddDays(6).AddHours(15), Airline = "Delta", Price = 400.00m, CabinClass = "Business" }
            };

            context.Flights.AddRange(flights);
            context.SaveChanges();
        }

        //seed users
        public static void SeedUsers(AppDbContext context)
        {
            if (context.Users.Any()) return;

            var users = new List<User>
            {
                new User { FirstName = "Alice", LastName = "Johnson", Email = "alice@example.com", PasswordHash = "HASHED_pw1", CreatedAt = DateTime.UtcNow.AddMonths(-3) },
                new User { FirstName = "Bob", LastName = "Smith", Email = "bob@example.com", PasswordHash = "HASHED_pw2", CreatedAt = DateTime.UtcNow.AddMonths(-2) },
                new User { FirstName = "Carol", LastName = "Ng", Email = "carol@example.com", PasswordHash = "HASHED_pw3", CreatedAt = DateTime.UtcNow.AddMonths(-1) },
                new User { FirstName = "David", LastName = "Lee", Email = "david@example.com", PasswordHash = "HASHED_pw4", CreatedAt = DateTime.UtcNow.AddDays(-10) },
                new User { FirstName = "Eve", LastName = "Martinez", Email = "eve@example.com", PasswordHash = "HASHED_pw5", CreatedAt = DateTime.UtcNow.AddDays(-5) }
            };

            context.Users.AddRange(users);
            context.SaveChanges();
        }

        //seed bookings (depends on users + flights)
        public static void SeedBookings(AppDbContext context)
        {
            if (context.Bookings.Any()) return;

            // Ensure there are users and flights
            if (!context.Users.Any()) SeedUsers(context);
            if (!context.Flights.Any()) SeedFlights(context);

            var users = context.Users.OrderBy(u => u.UserId).Take(5).ToList();
            var flights = context.Flights.OrderBy(f => f.FlightId).Take(10).ToList();

            if (!users.Any() || !flights.Any()) return;

            var bookings = new List<Booking>
            {
                new Booking { UserId = users[0].UserId, FlightId = flights[0].FlightId, BookingDate = DateTime.UtcNow.AddDays(-15), Status = "Confirmed", PassengerName = $"{users[0].FirstName} {users[0].LastName}" },
                new Booking { UserId = users[1].UserId, FlightId = flights[2].FlightId, BookingDate = DateTime.UtcNow.AddDays(-10), Status = "Confirmed", PassengerName = $"{users[1].FirstName} {users[1].LastName}" },
                new Booking { UserId = users[2].UserId, FlightId = flights[3].FlightId, BookingDate = DateTime.UtcNow.AddDays(-7), Status = "Cancelled", PassengerName = $"{users[2].FirstName} {users[2].LastName}" },
                new Booking { UserId = users[3].UserId, FlightId = flights[4].FlightId, BookingDate = DateTime.UtcNow.AddDays(-3), Status = "Pending", PassengerName = $"{users[3].FirstName} {users[3].LastName}" },
                new Booking { UserId = users[4].UserId, FlightId = flights[1].FlightId, BookingDate = DateTime.UtcNow.AddDays(-1), Status = "Confirmed", PassengerName = $"{users[4].FirstName} {users[4].LastName}" }
            };

            context.Bookings.AddRange(bookings);
            context.SaveChanges();
        }

        //seed payments (depends on bookings)
        public static void SeedPayments(AppDbContext context)
        {
            if (context.Payments.Any()) return;

            if (!context.Bookings.Any()) SeedBookings(context);

            var bookings = context.Bookings.OrderBy(b => b.BookingId).Take(5).ToList();
            if (!bookings.Any()) return;

            var payments = new List<Payment>();
            foreach (var b in bookings)
            {
                var flight = context.Flights.Find(b.FlightId);
                var amount = flight?.Price ?? 100.00m;
                payments.Add(new Payment
                {
                    BookingId = b.BookingId,
                    Amount = amount,
                    PaymentDate = b.BookingDate.AddDays(1),
                    Status = b.Status == "Cancelled" ? "Refunded" : "Completed"
                });
            }

            context.Payments.AddRange(payments);
            context.SaveChanges();
        }

        // seed everything in correct order
        public static void SeedAll(AppDbContext context)
        {
            SeedUsers(context);
            SeedFlights(context);
            SeedBookings(context);
            SeedPayments(context);
        }
    }
}
