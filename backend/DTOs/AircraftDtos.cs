using System;

namespace backend.DTOs;

public class AircraftDto
{
    public int Id { get; set; }
    public string IcaoCode { get; set; } = null!;
    public string? IataCode { get; set; }
    public string Manufacturer { get; set; } = null!;
    public string Model { get; set; } = null!;
    public string Category { get; set; } = null!;
    public int CruiseSpeedKmh { get; set; }
    public int? RangeKm { get; set; }

    public List<SeatDto> Seats { get; set; } = new();
}

public class SeatDto
{
    public string Class { get; set; } = null!;
    public int SeatCount { get; set; }
}
