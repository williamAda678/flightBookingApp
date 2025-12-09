using System.Linq;
using Microsoft.AspNetCore.Mvc;
using FlightBookingApp.Data;

namespace FlightBookingApp.Controllers
{
    public class FlightsController : Controller
    {
        private readonly AppDbContext _db;

        public FlightsController(AppDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            var flights = _db.Flights.OrderBy(f => f.DepartureTime).ToList();
            return View(flights);
        }

        public IActionResult Details(int id)
        {
            var flight = _db.Flights.FirstOrDefault(f => f.FlightId == id);
            if (flight == null) return NotFound();
            return View(flight);
        }
    }
}
