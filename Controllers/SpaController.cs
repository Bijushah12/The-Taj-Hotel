using Microsoft.AspNetCore.Mvc;
using HotelBooking.Models;
using HotelBooking.Data;
using System.Collections.Generic;
using System;

namespace HotelBooking.Controllers
{
    public class SpaController : Controller
    {
        private readonly AppDbContext _context;

        public SpaController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var spaServices = new List<SpaService>
            {
                new SpaService {
                    Name="Full Body Massage", Price=2500,
                    Description="A relaxing massage for your entire body to relieve stress and tension, improves blood circulation, and restores energy.",
                    Icon="💆‍♀️", Color="#ff9a9e"
                },
                new SpaService {
                    Name="Aromatherapy", Price=1800,
                    Description="Therapeutic use of essential oils to enhance physical and emotional well-being. Promotes relaxation and reduces anxiety.",
                    Icon="🌸", Color="#fad0c4"
                },
                new SpaService {
                    Name="Facial Treatment", Price=1500,
                    Description="Deep cleansing and hydration to rejuvenate your skin. Reduces fine lines and leaves your skin glowing.",
                    Icon="✨", Color="#a1c4fd"
                },
                new SpaService {
                    Name="Hot Stone Therapy", Price=3000,
                    Description="Heated stones placed on specific points of the body to relieve tension and improve circulation.",
                    Icon="🔥", Color="#fbc2eb"
                },
                new SpaService {
                    Name="Steam Bath", Price=1200,
                    Description="Detoxify your body and open up your pores with a soothing steam bath session.",
                    Icon="🧖‍♂️", Color="#ffecd2"
                },
                new SpaService {
                    Name="Reflexology", Price=2000,
                    Description="Foot and hand massage focusing on reflex points to improve overall body health and relieve stress.",
                    Icon="🦶", Color="#fddb92"
                },
                new SpaService {
                    Name="Body Scrub", Price=1800,
                    Description="Exfoliate dead skin cells for smooth and glowing skin. Choice of natural scrubs included.",
                    Icon="🛁", Color="#c2e9fb"
                },
                new SpaService {
                    Name="Mud Therapy", Price=2200,
                    Description="Detoxifying mud wraps that remove toxins, hydrate the skin, and soothe muscle pain.",
                    Icon="🟤", Color="#d9a7c7"
                },
                new SpaService {
                    Name="Yoga Session", Price=1200,
                    Description="Guided yoga session to improve flexibility, strengthen muscles, and reduce stress.",
                    Icon="🧘‍♀️", Color="#a1c4fd"
                },
            };

            return View(spaServices);
        }

        [HttpPost]
        public IActionResult BookSpa(string serviceName, int price, DateTime bookingDate, TimeSpan bookingTime)
        {
            try
            {
                SpaBooking booking = new SpaBooking()
                {
                    UserId = 1, // later you can replace with session user
                    ServiceName = serviceName,
                    Price = price,
                    BookingDate = bookingDate,
                    BookingTime = bookingTime,
                    CreatedAt = DateTime.Now
                };

                _context.SpaBookings.Add(booking);
                _context.SaveChanges();

                TempData["Success"] = "✅ Spa Booking Confirmed Successfully!";
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
