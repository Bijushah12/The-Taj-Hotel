using Microsoft.AspNetCore.Mvc;
using HotelBooking.Data;
using HotelBooking.Models;
using System.Linq;

namespace HotelBooking.Controllers
{
    public class AdminBookingsController : Controller
    {
        private readonly AppDbContext _context;

        public AdminBookingsController(AppDbContext context)
        {
            _context = context;
        }

        // ========================
        // LIST BOOKINGS (UPDATED)
        // ========================
        public IActionResult Index()
        {
            var bookings = _context.RoomBookings
                .OrderByDescending(b => b.Id) // latest first
                .ToList();

            return View(bookings);
        }

        // ========================
        // CHANGE STATUS
        // ========================
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult ChangeStatus(int id, string status)
        {
            var booking = _context.RoomBookings.Find(id);

            if (booking == null)
                return NotFound();

            booking.Status = status;
            _context.SaveChanges();

            // ✅ Redirect so UI refreshes
            return RedirectToAction("Index");
        }

        // ========================
        // DELETE BOOKING
        // ========================
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(int id)
        {
            var booking = _context.RoomBookings.Find(id);

            if (booking == null)
                return NotFound();

            _context.RoomBookings.Remove(booking);
            _context.SaveChanges();

            // ✅ Redirect so UI updates
            return RedirectToAction("Index");
        }
    }
}