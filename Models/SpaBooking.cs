using System;

namespace HotelBooking.Models
{
    public class SpaBooking
    {
        public int Id { get; set; }

        public int UserId { get; set; }

        public string ServiceName { get; set; }

        public int Price { get; set; }

        public DateTime BookingDate { get; set; }   // DATE

        public TimeSpan BookingTime { get; set; }   // TIME(7)

        public DateTime? CreatedAt { get; set; }    // DATETIME NULL
        public string Status { get; set; }
    }
}
