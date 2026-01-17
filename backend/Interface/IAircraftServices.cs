using System;
using backend.DTOs;
using backend.Model;

namespace backend.Interface;

public interface IAircraftServices
{
    Task<IEnumerable<Aircraft>> GetAircraftAsync();
    Task<Aircraft?> GetAircraftByIcaoCodeAsync(string IcaoCode);
    Task<IEnumerable<AircraftDto>> GetAircraftWithSeatsConfigAsync();
}
