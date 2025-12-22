using System.Security.Cryptography.X509Certificates;
using backend.DTOs;
using backend.Extensions;
using backend.Interface;
using backend.Model;
using Microsoft.AspNetCore.Mvc;

namespace backend.Controllers.Api
{
    [ApiController]
    [Route("api/[controller]")]
    public class FlightsController : ControllerBase
    {
        private readonly IFlightService _flightService;
        public FlightsController(IFlightService flightService)
        {
            _flightService = flightService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var flights = await _flightService.GetAllFlightAsync();
            return Ok(flights);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var flight = await _flightService.GetFlightByIdAsync(id);
            if (flight == null) return NotFound();
            return Ok(flight);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreateFlightDto createflight)
        {
            var flight = ToDTOs.ToCreateFlightDto(createflight);
            var CreatedFlight = await _flightService.CreateFlightAsync(flight);
            return Ok(CreatedFlight);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, [FromBody] UpdateFlightDto flight)
        {
            var ok = await _flightService.UpdateFlightAsync(id, flight);
            if (!ok) return NotFound();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var beenDeleted = await _flightService.DeleteFlightAsync(id);
            if (!beenDeleted) return NotFound();
            return NoContent();
        }

        [HttpGet("search")]
        public async Task<IActionResult> GetFlightSearch([FromQuery] SearchFlightDto searchflight)
        {
            if (searchflight == null) return BadRequest("Missing search parameters.");

            var flights = await _flightService.SearchFlightAsync(searchflight);
            if (flights == null || !flights.Any()) return NotFound("No flights found.");
            return Ok(flights);
        }

    }
}
