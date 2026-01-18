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
            DepartureTime = new DateTime(2026, 1, 18, 14, 0, 0),
            ArrivalTime = new DateTime(2026, 1, 18, 21, 0, 0),
            Airline = "Delta",
            CabinClass = "Economy",
            Price = 299.99m,
            FlightId = 1,
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
                    DepartureTime =  new DateTime(2026, 1, 18, 14, 0, 0),
                    ArrivalTime =new DateTime(2026, 1, 18, 21, 0, 0),
                    Airline = "Delta",
                    CabinClass = "Economy",
                    Price = 350.00m,
                    FlightId = 1,
                },
                new Flight
                {
                    Origin = "LHR",
                    Destination = "DXB",
                    DepartureTime =  new DateTime(2026, 1, 18, 14, 0, 0),
                    ArrivalTime = new DateTime(2026, 1, 18, 21, 0, 0),
                    Airline = "Emirates",
                    CabinClass = "Business",
                    Price = 1250.00m,
                    FlightId = 2,
                }
            ];
    }
}
