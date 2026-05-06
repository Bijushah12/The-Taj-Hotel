using Microsoft.AspNetCore.Mvc;
using HotelBooking.Data;
using System.Linq;

namespace HotelBooking.Controllers
{
    public class RoomsController : Controller
    {
        private readonly AppDbContext _context;

        public RoomsController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var rooms = _context.Rooms.ToList();
            return View(rooms);
        }

        public IActionResult Details(int id)
        {
            var room = _context.Rooms.FirstOrDefault(x => x.Id == id);
            return View(room);
        }
    }
}