using System;

namespace backend.Model;

public class Aircraft
{
    public int Id { get; set; }
    public string IcaoCode { get; set; } = null!;
    public string? IataCode { get; set; }
    public string Manufacturer { get; set; } = null!;
    public string Model { get; set; } = null!;
    public string Category { get; set; } = null!;
    public int CruiseSpeedKmh { get; set; }
    public int? TypicalSeats { get; set; }
    public int? RangeKm { get; set; }
}
