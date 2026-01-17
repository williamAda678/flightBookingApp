using System;
using backend.Extensions;
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

    public async Task<double> GetAirportDistance(string origin, string destination)
    {
        var originAirport = _db.Airport.FirstOrDefault(x => x.IataCode == origin);
        var destinationAirport = _db.Airport.FirstOrDefault(x => x.IataCode == destination);
        if(originAirport == null || destinationAirport == null) return 0;


        return Helper.GetDistanceBetweenAirports(originAirport,destinationAirport);
    }

   
}
