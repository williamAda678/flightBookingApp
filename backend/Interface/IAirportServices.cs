using System;
using backend.Model;

namespace backend.Interface;

public interface IAirportServices
{
    Task<IEnumerable<Airport>> GetAllAirportsAsync();
    Task<Airport?> GetAirportByIcaoCodeAsync(string IcaoCode);
    Task<double> GetAirportDistance(string origin, string destination);
}
