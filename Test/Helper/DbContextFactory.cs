using System;
using FlightBookingApp.Data;
using Microsoft.EntityFrameworkCore;

namespace Test.Helper;

public static class DbContextFactory
{

    public static AppDbContext Create()
    {
        var options = new DbContextOptionsBuilder<AppDbContext>()
            .UseInMemoryDatabase(Guid.NewGuid().ToString())
            .Options;

        return new AppDbContext(options);
    }

}
