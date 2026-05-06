namespace HotelBooking.Models
{
    public class RestaurantOrder
    {
        public int Id { get; set; }

        public string ItemName { get; set; }

        public DateTime OrderDate { get; set; }

        public string Status { get; set; }
    }
}
