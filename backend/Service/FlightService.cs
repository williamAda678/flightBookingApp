using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using backend.Interface;
using backend.Model;
using FlightBookingApp.Data;
using Microsoft.AspNetCore.Http.HttpResults;
using backend.Extensions;
using backend.DTOs;

namespace backend.Service;

public class FlightService(AppDbContext db) : IFlightService
{

    private readonly AppDbContext _db = db;

    public async Task<Flight> CreateFlightAsync(Flight flight)
    {

        await _db.AddAsync(flight);
        await _db.SaveChangesAsync();
        return flight;
    }

    public async Task<bool> DeleteFlightAsync(int id)
    {
        var flight = await _db.Flights.FindAsync(id);
        if (flight == null) return false;

        _db.Remove(flight);
        await _db.SaveChangesAsync();
        return true;
    }

    public async Task<IEnumerable<Flight>> GetAllFlightAsync()
    {

        return await _db.Flights.ToListAsync();
    }

    public Task<Flight?> GetFlightByIdAsync(int id)
    {
        return _db.Flights.FirstOrDefaultAsync(f => f.FlightId == id);
    }

    public async Task<bool> UpdateFlightAsync(int id, UpdateFlightDto Updateflight)
    {
        var flight = await _db.Flights.FindAsync(id);
        if (flight == null) return false;


        ToDTOs.ToUpdateFlightDto(Updateflight, flight);

        await _db.SaveChangesAsync();

        return true;
    }
}
