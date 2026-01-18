using System;
using backend.Model;
using backend.Service;
using FluentAssertions;
using Microsoft.EntityFrameworkCore.Internal;
using Test.Helper;
using Test.TestData;

namespace Test.Services;

public class FlightServiceTest
{


    [Fact]
    public async Task CreateFlightAsync_AddsFlight()
    {
        // Arrange
        var context = DbContextFactory.Create();
        var service = new FlightServices(context);

        var flight = FlightData.CreateVaildFlight();

        // Act
        var result = await service.CreateFlightAsync(flight);

        // Assert
        result.Should().NotBeNull();
        context.Flights.Should().HaveCount(1);
        context.Flights.First().Origin.Should().Be("NYC");
    }

    [Fact]
    public async Task GetAllFlightAsync_ReturnsAllFlights()
    {
        // Arrange
        var context = DbContextFactory.Create();
        context.Flights.AddRange(
            FlightData.CreateMultipleFlights()
        );
        await context.SaveChangesAsync();

        var service = new FlightServices(context);

        // Act
        var flights = await service.GetAllFlightAsync();

        // Assert
        flights.Should().HaveCount(2);
    }

    [Fact]
    public async Task GetAllFlightByidAsync_ReturnsAllFlights()
    {
        // Arrange
        var result = FlightData.CreateVaildFlight();
        var context = DbContextFactory.Create();
        context.Flights.AddRange(
            FlightData.CreateVaildFlight()
        );
        await context.SaveChangesAsync();

        var service = new FlightServices(context);

        // Act
        var flights = await service.GetFlightByIdAsync(1);

        // Assert
        flights.Should().BeEquivalentTo(result);
    }
}
