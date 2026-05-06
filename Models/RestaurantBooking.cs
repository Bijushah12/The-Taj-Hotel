using System;

namespace HotelBooking.Models
{
    public class RestaurantBooking
    {
        public int Id { get; set; }

        public int UserId { get; set; }

        public string TableType { get; set; }

        public DateTime BookingDate { get; set; }

        public TimeSpan BookingTime { get; set; }

        public int Guests { get; set; }

        public DateTime? CreatedAt { get; set; }
    }
}
