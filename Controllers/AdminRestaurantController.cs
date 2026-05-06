using Microsoft.AspNetCore.Mvc;
using HotelBooking.Models;

namespace HotelBooking.Controllers
{
    public class AdminRestaurantController : Controller
    {
       

        private static List<RestaurantOrder> orders = new List<RestaurantOrder>()
    {
        new RestaurantOrder{ Id=1, ItemName="Pizza", OrderDate=DateTime.Now, Status="Pending"},
        new RestaurantOrder{ Id=2, ItemName="Burger", OrderDate=DateTime.Now, Status="Confirmed"},
        new RestaurantOrder{ Id=3, ItemName="Pasta", OrderDate=DateTime.Now, Status="Pending"}
    };

        public IActionResult Index()
        {
            return View();
        }

        public JsonResult GetOrders()
        {
            return Json(orders);
        }

        [HttpPost]
        public JsonResult ChangeStatus(int id, string status)
        {
            var order = orders.FirstOrDefault(x => x.Id == id);

            if (order != null)
            {
                order.Status = status;
            }

            return Json(new { success = true });
        }

        [HttpPost]
        public JsonResult Delete(int id)
        {
            var order = orders.FirstOrDefault(x => x.Id == id);

            if (order != null)
            {
                orders.Remove(order);
            }

            return Json(new { success = true });
        }
    }
}
