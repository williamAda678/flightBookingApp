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
    }
}
