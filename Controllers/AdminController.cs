using HotelBooking.Data;
using HotelBooking.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HotelBooking.Controllers
{
    public class AdminController : Controller
    {
        private readonly AppDbContext _context;

        // ✅ FIX: Inject DbContext
        public AdminController(AppDbContext context)
        {
            _context = context;
        }

        // =========================
        // LOGIN (GET)
        // =========================
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        // =========================
        // LOGIN (POST)
        // =========================
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Login(AdminLoginViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            // 🔴 TEMP LOGIN (replace with DB later)
            if (model.Username == "admin" && model.Password == "12345")
            {
                HttpContext.Session.SetString("AdminUser", model.Username);

                if (model.RememberMe)
                {
                    Response.Cookies.Append(
                        "AdminUser",
                        model.Username,
                        new CookieOptions { Expires = DateTime.Now.AddDays(7) }
                    );
                }

                return RedirectToAction("Dashboard");
            }

            ViewBag.ServerError = "Invalid username or password";
            return View(model);
        }

        public IActionResult Dashboard()
        {
            var model = new AdminDashboardViewModel
            {
                TotalBookings = 120,
                SpaBookings = 45,
                RestaurantOrders = 67,
                Contacts = 12,
                TodayCheckins = 5,
                RecentBookings = new List<RecentBooking>
                {
                    new RecentBooking { RoomType = "Deluxe", CheckIn = "2026-03-02" },
                    new RecentBooking { RoomType = "Suite", CheckIn = "2026-03-03" }
                }
            };

            return View(model);
        }

        // =========================
        // USERS LIST
        // =========================
        public IActionResult Users()
        {
            var users = _context.Users.ToList(); // ✅ now works
            return View(users); // Views/Admin/Users.cshtml
        }

        // =========================
        // LOGOUT
        // =========================
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Login");
        }
    }
}