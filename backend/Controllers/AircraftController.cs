using backend.Interface;
using backend.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AircraftController : ControllerBase
    {
        private readonly IAircraftServices _aircraftServices;

        public AircraftController(IAircraftServices aircraftServices)
        {
            _aircraftServices = aircraftServices;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var aircrafts = _aircraftServices.GetAircraftAsync();
            return Ok(aircrafts);
        }

        [HttpGet("{IcaoCode}")]
        public async Task<IActionResult> Get(string IcaoCode)
        {
            var aircraft = _aircraftServices.GetAircraftByIcaoCodeAsync(IcaoCode);
            if (aircraft == null) return NotFound("Unable to find aircraft");

            return Ok(aircraft);
        }
    }
}
