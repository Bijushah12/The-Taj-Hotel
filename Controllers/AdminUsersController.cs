using HotelBooking.Data;
using HotelBooking.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace HotelBooking.Controllers
{
    public class AdminUsersController : Controller
    {
        private readonly AppDbContext _context;

        public AdminUsersController(AppDbContext context)
        {
            _context = context;
        }

        // ========================
        // LIST USERS
        // ========================
        public IActionResult Index()
        {
            var users = _context.Users.ToList();
            return View(users); // Views/AdminUsers/Index.cshtml
        }

        // ========================
        // DELETE (GET) - SHOW CONFIRMATION
        // ========================
        public IActionResult Delete(int? id)
        {
            if (id == null)
                return NotFound();

            var user = _context.Users.FirstOrDefault(u => u.Id == id);

            if (user == null)
                return NotFound();

            return View(user); // Views/AdminUsers/Delete.cshtml
        }

        // ========================
        // DELETE (POST) - ACTUAL DELETE
        // ========================
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(int id)
        {
            var user = _context.Users.Find(id);

            if (user != null)
            {
                _context.Users.Remove(user);
                _context.SaveChanges();
            }

            return RedirectToAction(nameof(Index));
        }
    }
}