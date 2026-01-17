using backend.Extensions;
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
            var airport = _airportServices.GetAllAirportsAsync();
            return Ok(airport);
        }

        [HttpGet("{iataCode}")]
        public async Task<IActionResult> Get(string iataCode)
        {
            var airport = _airportServices.GetAirportByIcaoCodeAsync(iataCode);
            if (airport == null) return NotFound("Unable to find aircraft");

            return Ok(airport);
        }

        [HttpGet("distance")]
        public async Task<IActionResult> Get([FromQuery] string origin, string destination)
        {
            var distance = await _airportServices.GetAirportDistance(origin, destination);
            if (distance == 0) return NotFound("Unable to find aircraft");
            return Ok(ToDTOs.ToDistanceDTOs(distance));
        }
    }
}
