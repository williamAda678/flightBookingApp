using System;
using backend.DTOs;
using backend.Model;

namespace backend.Extensions;

public class ToDTOs
{
    public static FlightDto ToReadDto(Flight flight)
    {
        return new FlightDto
        {
            FlightId = flight.FlightId,
            Origin = flight.Origin,
            Destination = flight.Destination,
            DepartureTime = flight.DepartureTime,
            ArrivalTime = flight.ArrivalTime,
            Airline = flight.Airline,
            Price = flight.Price,
            CabinClass = flight.CabinClass
        };
    }

    public static Flight ToCreateFlightDto(CreateFlightDto flight)
    {
        return new Flight
        {
            Origin = flight.Origin,
            Destination = flight.Destination,
            DepartureTime = flight.DepartureTime,
            ArrivalTime = flight.ArrivalTime,
            Airline = flight.Airline,
            Price = flight.Price,
            CabinClass = flight.CabinClass
        };
    }
    public static void ToUpdateFlightDto(UpdateFlightDto updateFlight, Flight flight)
    {

        flight.Origin = updateFlight.Origin;
        flight.Destination = updateFlight.Destination;
        flight.DepartureTime = updateFlight.DepartureTime;
        flight.ArrivalTime = updateFlight.ArrivalTime;
        flight.Airline = updateFlight.Airline;
        flight.Price = updateFlight.Price;
        flight.CabinClass = updateFlight.CabinClass;

    }
}
