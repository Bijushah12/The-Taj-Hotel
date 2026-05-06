using Microsoft.AspNetCore.Mvc;
using HotelBooking.Data;
using HotelBooking.Models;
using System.Linq;

public class AdminContactController : Controller
{
    private readonly AppDbContext _context;

    public AdminContactController(AppDbContext context)
    {
        _context = context;
    }

    public IActionResult Index()
    {
        var messages = _context.ContactMessages.ToList();
        return View(messages);
    }

    [HttpPost]
    public IActionResult ChangeStatus(int id, string status)
    {
        var message = _context.ContactMessages.Find(id);

        if (message != null)
        {
            message.Status = status;
            _context.SaveChanges();
        }

        return Ok();
    }

    [HttpPost]
    public IActionResult Delete(int id)
    {
        var message = _context.ContactMessages.Find(id);

        if (message != null)
        {
            _context.ContactMessages.Remove(message);
            _context.SaveChanges();
        }

        return Ok();
    }
}