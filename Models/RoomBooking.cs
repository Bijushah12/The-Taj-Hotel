//public class RoomBooking
//{
//    public int Id { get; set; }
//    public string RoomType { get; set; }
//    public int Price { get; set; }
//    public DateTime CheckIn { get; set; }
//    public DateTime CheckOut { get; set; }
//    public int Guests { get; set; }
//    public int Nights { get; set; }
//    public int TotalAmount { get; set; }
//    public DateTime BookingDate { get; set; }
//    public int UserId { get; set; }
//}

using System;

namespace HotelBooking.Models
{
    public class RoomBooking
    {
        public int Id { get; set; }

        public int UserId { get; set; }

        public string RoomType { get; set; }

        public int Price { get; set; }

        public DateTime CheckIn { get; set; }

        public DateTime CheckOut { get; set; }

        public int Nights { get; set; }

        public int TotalAmount { get; set; }

        public DateTime BookingDate { get; set; }

        // Added for Admin Booking Panel
        public string Status { get; set; } = "Pending";
    }
}