using backend.Model;
using FlightBookingApp.Data;
using Microsoft.AspNetCore.Mvc;

namespace FlightBookingApp.Controllers.Api
{
    [ApiController]
    [Route("api/[controller]")]
    public class FlightsController : ControllerBase
    {
        private readonly AppDbContext _db;

        public FlightsController(AppDbContext db)
        {
            _db = db;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Flight>> GetFlights()
        {
            var flights = _db.Flights.OrderBy(f => f.DepartureTime).ToList();
            return Ok(flights);
        }

        [HttpGet("{id}")]
        public ActionResult<Flight> GetFlight(int id)
        {
            var flight = _db.Flights.FirstOrDefault(f => f.FlightId == id);
            if (flight == null) return NotFound();
            return Ok(flight);
        }
    }
}
