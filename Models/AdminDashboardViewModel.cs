using System.Collections.Generic;

namespace HotelBooking.Models
{
    public class AdminDashboardViewModel
    {
        public int TotalBookings { get; set; }
        public int SpaBookings { get; set; }
        public int RestaurantOrders { get; set; }
        public int Contacts { get; set; }
        public int TodayCheckins { get; set; }

        public List<RecentBooking> RecentBookings { get; set; }
    }

    public class RecentBooking
    {
        public string RoomType { get; set; }
        public string CheckIn { get; set; }
    }
}
