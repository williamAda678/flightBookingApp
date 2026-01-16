using System;

namespace backend.Model;

public class Airport
{
    public int Id { get; set; }
    public string IataCode { get; set; } = null!;
    public string IcaoCode { get; set; } = null!;
    public string Name { get; set; } = null!;
    public string City { get; set; } = null!;
    public string Country { get; set; } = null!;
    public double Latitude { get; set; }
    public double Longitude { get; set; }
}
