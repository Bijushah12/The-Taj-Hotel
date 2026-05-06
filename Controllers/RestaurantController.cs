using Microsoft.AspNetCore.Mvc;
using HotelBooking.Data;
using HotelBooking.Models;
using System;

namespace HotelBooking.Controllers
{
    public class RestaurantController : Controller
    {
        private readonly AppDbContext _context;

        public RestaurantController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult BookTable(string tableType, DateTime bookingDate, TimeSpan bookingTime, int guests)
        {
            try
            {
                RestaurantBooking booking = new RestaurantBooking()
                {
                    UserId = 1,  // later you can take from session
                    TableType = tableType,
                    BookingDate = bookingDate,
                    BookingTime = bookingTime,
                    Guests = guests,
                    CreatedAt = DateTime.Now
                };

                _context.RestaurantBookings.Add(booking);
                _context.SaveChanges();

                TempData["Success"] = "✅ Restaurant Booking Confirmed!";
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                TempData["Error"] = "❌ Booking Failed: " + ex.InnerException?.Message;
                return RedirectToAction("Index");
            }
        }
    }
}
