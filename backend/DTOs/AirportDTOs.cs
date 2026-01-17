using System;

namespace backend.DTOs;

public class Airport
{
    public class DistanceDTOs
    {
        public double DistanceKm { get; set; }
        public double NauticalMiles { get; set; }
        public double Miles { get; set; }
        public double FlightTime { get; set; }
    }
}
