using System;
using backend.DTOs;
using backend.Model;

namespace backend.Interface;

public interface IFlightServices
{

    Task<IEnumerable<Flight>> GetAllFlightAsync();
    Task<Flight?> GetFlightByIdAsync(int id);
    Task<Flight> CreateFlightAsync(Flight flight);
    Task<bool> UpdateFlightAsync(int id, UpdateFlightDto flight);
    Task<bool> DeleteFlightAsync(int id);
    Task<List<Flight?>> SearchFlightAsync(SearchFlightDto searchflight);
    Task<IEnumerable<AirportDto>> GetAllAirportsAsync();

}
