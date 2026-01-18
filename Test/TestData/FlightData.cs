using System;
using backend.Model;

namespace Test.TestData;

public static class FlightData
{
    public static Flight CreateVaildFlight()
    {
        return new Flight
        {
            Origin = "NYC",
            Destination = "LAX",
            DepartureTime = DateTime.UtcNow.AddHours(2),
            ArrivalTime = DateTime.UtcNow.AddHours(5),
            Airline = "Delta",
            CabinClass = "Economy",
            Price = 299.99m
        };
    }

    public static List<Flight> CreateMultipleFlights()
    {
        return
            [
                new Flight
                {
                    Origin = "NYC",
                    Destination = "LAX",
                    DepartureTime = DateTime.UtcNow.AddHours(2),
                    ArrivalTime = DateTime.UtcNow.AddHours(7),
                    Airline = "Delta",
                    CabinClass = "Economy",
                    Price = 350.00m
                },
                new Flight
                {
                    Origin = "LHR",
                    Destination = "DXB",
                    DepartureTime = DateTime.UtcNow.AddHours(5),
                    ArrivalTime = DateTime.UtcNow.AddHours(12),
                    Airline = "Emirates",
                    CabinClass = "Business",
                    Price = 1250.00m
                }
            ];
    }
}
