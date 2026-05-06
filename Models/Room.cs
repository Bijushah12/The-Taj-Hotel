namespace HotelBooking.Models
{
    //public class Room
    //{
    //    public int Id { get; set; }
    //    public string Type { get; set; }
    //    public int Price { get; set; }
    //    public string Image { get; set; }
    //    public string Bg { get; set; }
    //    public string Location { get; set; }
    //    public string Amenities { get; set; }
    //    public int? OriginalPrice { get; set; }
    //    public bool HasDiscount { get; set; }
    //    public int DiscountPercentage { get; set; }
    //}

    public class Room
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string ImageUrl { get; set; }

        public string Description { get; set; }

        public int PricePerNight { get; set; }

        public int Capacity { get; set; }
    }
}
