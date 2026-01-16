using System;
using backend.Interface;
using backend.Model;
using FlightBookingApp.Data;
using Microsoft.EntityFrameworkCore;

namespace backend.Service;

public class AircraftServices(AppDbContext db) : IAircraftServices
{

    private readonly AppDbContext _db = db;

    public async Task<IEnumerable<Aircraft>> GetAircraftAsync()
    {
        return await _db.Aircraft.ToListAsync();
    }

    public async Task<Aircraft?> GetAircraftByIcaoCodeAsync(string IcaoCode)
    {
        return await _db.Aircraft.FirstOrDefaultAsync(x => x.IcaoCode == IcaoCode);
    }
}
