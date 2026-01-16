using System;
using backend.Interface;
using backend.Model;
using FlightBookingApp.Data;
using Microsoft.EntityFrameworkCore;

namespace backend.Service;

public class AirportServices(AppDbContext db) : IAirportServices
{
    private readonly AppDbContext _db = db;


    public async Task<IEnumerable<Airport>> GetAllAirportsAsync()
    {
        return await _db.Airport.ToListAsync();
    }


    public async Task<Airport?> GetAirportByIcaoCodeAsync(string iataCode)
    {
        return await _db.Airport.FirstOrDefaultAsync(x => x.IataCode == iataCode);
    }
}
