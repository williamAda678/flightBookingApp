using System;

namespace backend.DTOs;

public class FlightDto
{
    public int FlightId { get; set; }
    public string Origin { get; set; }
    public string Destination { get; set; }
    public DateTime DepartureTime { get; set; }
    public DateTime ArrivalTime { get; set; }
    public string Airline { get; set; }
    public decimal Price { get; set; }
    public string CabinClass { get; set; }
}

public class CreateFlightDto
{
    public string Origin { get; set; }
    public string Destination { get; set; }
    public DateTime DepartureTime { get; set; }
    public DateTime ArrivalTime { get; set; }
    public string Airline { get; set; }
    public decimal Price { get; set; }
    public string CabinClass { get; set; }
}

public class UpdateFlightDto
{

    public string Origin { get; set; }
    public string Destination { get; set; }
    public DateTime DepartureTime { get; set; }
    public DateTime ArrivalTime { get; set; }
    public string Airline { get; set; }
    public decimal Price { get; set; }
    public string CabinClass { get; set; }
}

public class SearchFlightDto
{

    public string? Origin { get; set; }
    public string? Destination { get; set; }
    public DateTime? DepartureDate { get; set; }
    public string? CabinClass { get; set; }
}
