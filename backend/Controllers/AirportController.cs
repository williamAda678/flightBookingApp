using backend.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AirportController : ControllerBase
    {
        private readonly IAirportServices _airportServices;

        public AirportController(IAirportServices airportServices)
        {
            _airportServices = airportServices;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var aircrafts = _airportServices.GetAllAirportsAsync();
            return Ok(aircrafts);
        }

        [HttpGet("{iataCode}")]
        public async Task<IActionResult> Get(string iataCode)
        {
            var aircraft = _airportServices.GetAirportByIcaoCodeAsync(iataCode);
            if (aircraft == null) return NotFound("Unable to find aircraft");

            return Ok(aircraft);
        }
    }
}
