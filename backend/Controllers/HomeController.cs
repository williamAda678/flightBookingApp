using System.Linq;
using Microsoft.AspNetCore.Mvc;
using FlightBookingApp.Data;

namespace FlightBookingApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _db;

        public HomeController(AppDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            var flights = _db.Flights.OrderBy(f => f.DepartureTime).ToList();
            return View(flights);
        }
    }
}
