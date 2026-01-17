using System;
using backend.DTOs;
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

    public async Task<IEnumerable<AircraftDto>> GetAircraftWithSeatsConfigAsync()
    {
        var aircraftList = await _db.Aircraft
        .Include(a => a.Seats)
        .ToListAsync();

        return aircraftList.Select(a => new AircraftDto
        {
            Id = a.Id,
            IcaoCode = a.IcaoCode,
            IataCode = a.IataCode,
            Manufacturer = a.Manufacturer,
            Model = a.Model,
            Category = a.Category,
            CruiseSpeedKmh = a.CruiseSpeedKmh,
            RangeKm = a.RangeKm,
            Seats = a.Seats.Select(s => new SeatDto
            {
                Class = s.Class,
                SeatCount = s.SeatCount
            }).ToList()
        }).ToList();
    }


    public async Task<Aircraft?> GetAircraftByIcaoCodeAsync(string IcaoCode)
    {
        return await _db.Aircraft.FirstOrDefaultAsync(x => x.IcaoCode == IcaoCode);
    }
}
