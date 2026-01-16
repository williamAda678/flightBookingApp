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
                new() { Origin = "JFK", Destination = "LAX", DepartureTime = DateTime.UtcNow.AddDays(3).AddHours(9), ArrivalTime = DateTime.UtcNow.AddDays(3).AddHours(14), Airline = "Delta", Price = 299.99m, CabinClass = "Economy" },
                new() { Origin = "LAX", Destination = "ORD", DepartureTime = DateTime.UtcNow.AddDays(4).AddHours(15), ArrivalTime = DateTime.UtcNow.AddDays(4).AddHours(20), Airline = "United", Price = 350.00m, CabinClass = "Business" },
                new() { Origin = "ATL", Destination = "MIA", DepartureTime = DateTime.UtcNow.AddDays(2).AddHours(8), ArrivalTime = DateTime.UtcNow.AddDays(2).AddHours(10), Airline = "American", Price = 150.00m, CabinClass = "Economy" },
                new() { Origin = "ORD", Destination = "SEA", DepartureTime = DateTime.UtcNow.AddDays(5).AddHours(13), ArrivalTime = DateTime.UtcNow.AddDays(5).AddHours(17), Airline = "Alaska", Price = 400.00m, CabinClass = "Business" },
                new() { Origin = "DFW", Destination = "DEN", DepartureTime = DateTime.UtcNow.AddDays(1).AddHours(7), ArrivalTime = DateTime.UtcNow.AddDays(1).AddHours(9), Airline = "Spirit", Price = 120.00m, CabinClass = "Economy" },
                new() { Origin = "SFO", Destination = "LAS", DepartureTime = DateTime.UtcNow.AddDays(3).AddHours(12), ArrivalTime = DateTime.UtcNow.AddDays(3).AddHours(14), Airline = "Southwest", Price = 180.00m, CabinClass = "Economy" },
                new() { Origin = "MIA", Destination = "BOS", DepartureTime = DateTime.UtcNow.AddDays(6).AddHours(9), ArrivalTime = DateTime.UtcNow.AddDays(6).AddHours(12), Airline = "JetBlue", Price = 220.00m, CabinClass = "Economy" },
                new() { Origin = "BOS", Destination = "JFK", DepartureTime = DateTime.UtcNow.AddDays(2).AddHours(11), ArrivalTime = DateTime.UtcNow.AddDays(2).AddHours(12), Airline = "Delta", Price = 110.00m, CabinClass = "Economy" },
                new() { Origin = "SEA", Destination = "SFO", DepartureTime = DateTime.UtcNow.AddDays(4).AddHours(10), ArrivalTime = DateTime.UtcNow.AddDays(4).AddHours(12), Airline = "Alaska", Price = 200.00m, CabinClass = "Business" },
                new() { Origin = "LAX", Destination = "ATL", DepartureTime = DateTime.UtcNow.AddDays(3).AddHours(14), ArrivalTime = DateTime.UtcNow.AddDays(3).AddHours(22), Airline = "Delta", Price = 320.00m, CabinClass = "Economy" },
                new() { Origin = "ORD", Destination = "MIA", DepartureTime = DateTime.UtcNow.AddDays(5).AddHours(9), ArrivalTime = DateTime.UtcNow.AddDays(5).AddHours(14), Airline = "American", Price = 280.00m, CabinClass = "Economy" },
                new() { Origin = "DFW", Destination = "LAX", DepartureTime = DateTime.UtcNow.AddDays(1).AddHours(16), ArrivalTime = DateTime.UtcNow.AddDays(1).AddHours(19), Airline = "Southwest", Price = 250.00m, CabinClass = "Business" },
                new() { Origin = "MIA", Destination = "ORD", DepartureTime = DateTime.UtcNow.AddDays(2).AddHours(7), ArrivalTime = DateTime.UtcNow.AddDays(2).AddHours(11), Airline = "United", Price = 260.00m, CabinClass = "Economy" },
                new() { Origin = "SFO", Destination = "SEA", DepartureTime = DateTime.UtcNow.AddDays(3).AddHours(13), ArrivalTime = DateTime.UtcNow.AddDays(3).AddHours(15), Airline = "Alaska", Price = 190.00m, CabinClass = "Economy" },
                new() { Origin = "JFK", Destination = "MIA", DepartureTime = DateTime.UtcNow.AddDays(4).AddHours(10), ArrivalTime = DateTime.UtcNow.AddDays(4).AddHours(14), Airline = "JetBlue", Price = 270.00m, CabinClass = "Business" },
                new() { Origin = "LAX", Destination = "SFO", DepartureTime = DateTime.UtcNow.AddDays(1).AddHours(8), ArrivalTime = DateTime.UtcNow.AddDays(1).AddHours(9), Airline = "Southwest", Price = 120.00m, CabinClass = "Economy" },
                new() { Origin = "ATL", Destination = "DFW", DepartureTime = DateTime.UtcNow.AddDays(2).AddHours(15), ArrivalTime = DateTime.UtcNow.AddDays(2).AddHours(18), Airline = "Spirit", Price = 140.00m, CabinClass = "Economy" },
                new() { Origin = "SEA", Destination = "ORD", DepartureTime = DateTime.UtcNow.AddDays(5).AddHours(12), ArrivalTime = DateTime.UtcNow.AddDays(5).AddHours(18), Airline = "United", Price = 310.00m, CabinClass = "Business" },
                new() { Origin = "BOS", Destination = "MIA", DepartureTime = DateTime.UtcNow.AddDays(3).AddHours(6), ArrivalTime = DateTime.UtcNow.AddDays(3).AddHours(10), Airline = "American", Price = 230.00m, CabinClass = "Economy" },
                new() { Origin = "JFK", Destination = "SEA", DepartureTime = DateTime.UtcNow.AddDays(6).AddHours(9), ArrivalTime = DateTime.UtcNow.AddDays(6).AddHours(15), Airline = "Delta", Price = 400.00m, CabinClass = "Business" }
            };

            context.Flights.AddRange(flights);
            context.SaveChanges();
        }

        public static void SeedAircraft(AppDbContext context)
        {
            if (context.Aircraft.Any())
            {
                return; // Data already seeded
            }

            var aircarft = new List<Aircraft>
                {
                new()
                {
                    IcaoCode = "A320",
                    IataCode = "320",
                    Manufacturer = "Airbus",
                    Model = "A320",
                    Category = "Narrow-body",
                    CruiseSpeedKmh = 830,
                    TypicalSeats = 180,
                    RangeKm = 6100
                },
                new()
                {
                    IcaoCode = "A321",
                    IataCode = "321",
                    Manufacturer = "Airbus",
                    Model = "A321",
                    Category = "Narrow-body",
                    CruiseSpeedKmh = 830,
                    TypicalSeats = 220,
                    RangeKm = 7400
                },
                new()
                {
                    IcaoCode = "A20N",
                    IataCode = "32N",
                    Manufacturer = "Airbus",
                    Model = "A320neo",
                    Category = "Narrow-body",
                    CruiseSpeedKmh = 835,
                    TypicalSeats = 180,
                    RangeKm = 6300
                },
                new()
                {
                    IcaoCode = "B738",
                    IataCode = "738",
                    Manufacturer = "Boeing",
                    Model = "737-800",
                    Category = "Narrow-body",
                    CruiseSpeedKmh = 830,
                    TypicalSeats = 189,
                    RangeKm = 5600
                },
                new()
                {
                    IcaoCode = "B739",
                    IataCode = "739",
                    Manufacturer = "Boeing",
                    Model = "737-900",
                    Category = "Narrow-body",
                    CruiseSpeedKmh = 830,
                    TypicalSeats = 220,
                    RangeKm = 5900
                },
                new() {
                    IcaoCode = "B788",
                    IataCode = "788",
                    Manufacturer = "Boeing",
                    Model = "787-8 Dreamliner",
                    Category = "Wide-body",
                    CruiseSpeedKmh = 900,
                    TypicalSeats = 250,
                    RangeKm = 13600
                },
                new()
                {
                    IcaoCode = "B789",
                    IataCode = "789",
                    Manufacturer = "Boeing",
                    Model = "787-9 Dreamliner",
                    Category = "Wide-body",
                    CruiseSpeedKmh = 900,
                    TypicalSeats = 290,
                    RangeKm = 14100
                },
                new()
                {
                    IcaoCode = "A359",
                    IataCode = "359",
                    Manufacturer = "Airbus",
                    Model = "A350-900",
                    Category = "Wide-body",
                    CruiseSpeedKmh = 905,
                    TypicalSeats = 300,
                    RangeKm = 15000
                },
                new()
                {
                    IcaoCode = "E190",
                    IataCode = "E90",
                    Manufacturer = "Embraer",
                    Model = "E190",
                    Category = "Regional Jet",
                    CruiseSpeedKmh = 820,
                    TypicalSeats = 100,
                    RangeKm = 4500
                },
                new()
                {
                    IcaoCode = "AT76",
                    IataCode = null,
                    Manufacturer = "ATR",
                    Model = "ATR 72-600",
                    Category = "Turboprop",
                    CruiseSpeedKmh = 510,
                    TypicalSeats = 70,
                    RangeKm = 1500
                }
             };
            context.Aircraft.AddRange(aircarft);
            context.SaveChanges();
        }



        public static void SeedAirpots(AppDbContext context)
        {
            if (context.Airport.Any())
            {
                return; // Data already seeded
            }

            var airports = new List<Airport>
            {
                new() {
                    IataCode = "ATL",
                    IcaoCode = "KATL",
                    Name = "Hartsfield–Jackson Atlanta International Airport",
                    City = "Atlanta",
                    Country = "US",
                    Latitude = 33.6407,
                    Longitude = -84.4277
                },
                new() {
                    IataCode = "LAX",
                    IcaoCode = "KLAX",
                    Name = "Los Angeles International Airport",
                    City = "Los Angeles",
                    Country = "US",
                    Latitude = 33.9416,
                    Longitude = -118.4085
                },
                new() {
                    IataCode = "ORD",
                    IcaoCode = "KORD",
                    Name = "O'Hare International Airport",
                    City = "Chicago",
                    Country = "US",
                    Latitude = 41.9742,
                    Longitude = -87.9073
                },
                new() {
                    IataCode = "DFW",
                    IcaoCode = "KDFW",
                    Name = "Dallas/Fort Worth International Airport",
                    City = "Dallas–Fort Worth",
                    Country = "US",
                    Latitude = 32.8998,
                    Longitude = -97.0403
                },
                new() {
                    IataCode = "DEN",
                    IcaoCode = "KDEN",
                    Name = "Denver International Airport",
                    City = "Denver",
                    Country = "US",
                    Latitude = 39.8561,
                    Longitude = -104.6737
                },
                new() {
                    IataCode = "JFK",
                    IcaoCode = "KJFK",
                    Name = "John F. Kennedy International Airport",
                    City = "New York",
                    Country = "US",
                    Latitude = 40.6413,
                    Longitude = -73.7781
                },
                new() {
                    IataCode = "SFO",
                    IcaoCode = "KSFO",
                    Name = "San Francisco International Airport",
                    City = "San Francisco",
                    Country = "US",
                    Latitude = 37.6213,
                    Longitude = -122.3790
                },
                new() {
                    IataCode = "SEA",
                    IcaoCode = "KSEA",
                    Name = "Seattle–Tacoma International Airport",
                    City = "Seattle",
                    Country = "US",
                    Latitude = 47.4502,
                    Longitude = -122.3088
                },
                new() {
                    IataCode = "LAS",
                    IcaoCode = "KLAS",
                    Name = "Harry Reid International Airport",
                    City = "Las Vegas",
                    Country = "US",
                    Latitude = 36.0840,
                    Longitude = -115.1537
                },
                new() {
                    IataCode = "MCO",
                    IcaoCode = "KMCO",
                    Name = "Orlando International Airport",
                    City = "Orlando",
                    Country = "US",
                    Latitude = 28.4312,
                    Longitude = -81.3081
                },
                new() {
                    IataCode = "MIA",
                    IcaoCode = "KMIA",
                    Name = "Miami International Airport",
                    City = "Miami",
                    Country = "US",
                    Latitude = 25.7959,
                    Longitude = -80.2870
                },
                new() {
                    IataCode = "PHX",
                    IcaoCode = "KPHX",
                    Name = "Phoenix Sky Harbor International Airport",
                    City = "Phoenix",
                    Country = "US",
                    Latitude = 33.4373,
                    Longitude = -112.0078
                },
                new() {
                    IataCode = "IAH",
                    IcaoCode = "KIAH",
                    Name = "George Bush Intercontinental Airport",
                    City = "Houston",
                    Country = "US",
                    Latitude = 29.9902,
                    Longitude = -95.3368
                },
                new() {
                    IataCode = "EWR",
                    IcaoCode = "KEWR",
                    Name = "Newark Liberty International Airport",
                    City = "Newark",
                    Country = "US",
                    Latitude = 40.6895,
                    Longitude = -74.1745
                },
                new() {
                    IataCode = "BOS",
                    IcaoCode = "KBOS",
                    Name = "Logan International Airport",
                    City = "Boston",
                    Country = "US",
                    Latitude = 42.3656,
                    Longitude = -71.0096
                },
                new() {
                    IataCode = "MSP",
                    IcaoCode = "KMSP",
                    Name = "Minneapolis–Saint Paul International Airport",
                    City = "Minneapolis",
                    Country = "US",
                    Latitude = 44.8848,
                    Longitude = -93.2223
                },
                new() {
                    IataCode = "DTW",
                    IcaoCode = "KDTW",
                    Name = "Detroit Metropolitan Airport",
                    City = "Detroit",
                    Country = "US",
                    Latitude = 42.2162,
                    Longitude = -83.3554
                },
                new() {
                    IataCode = "PHL",
                    IcaoCode = "KPHL",
                    Name = "Philadelphia International Airport",
                    City = "Philadelphia",
                    Country = "US",
                    Latitude = 39.8744,
                    Longitude = -75.2424
                },
                new() {
                    IataCode = "LGA",
                    IcaoCode = "KLGA",
                    Name = "LaGuardia Airport",
                    City = "New York",
                    Country = "US",
                    Latitude = 40.7769,
                    Longitude = -73.8740
                },
                new() {
                    IataCode = "BWI",
                    IcaoCode = "KBWI",
                    Name = "Baltimore/Washington International Airport",
                    City = "Baltimore",
                    Country = "US",
                    Latitude = 39.1754,
                    Longitude = -76.6684
                }

            };

            context.Airport.AddRange(airports);
            context.SaveChanges();
        }


        // seed everything in correct order
        public static void SeedAll(AppDbContext context)
        {
            SeedFlights(context);
            SeedAircraft(context);
            SeedAirpots(context);
        }
    }
}
