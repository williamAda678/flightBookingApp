using System;

namespace backend.Model;

public class Flight
{
    public int FlightId { get; set; }
    public string Origin { get; set; }
    public string Destination { get; set; }
    public DateTime DepartureTime { get; set; }
    public DateTime ArrivalTime { get; set; }
    public string Airline { get; set; }
    public decimal Price { get; set; }
    public string CabinClass { get; set; }

    public ICollection<Booking> Bookings { get; set; }
}

public class Airport
{
    public string airport { get; set; }
}
