//using System.ComponentModel.DataAnnotations;

//namespace HotelBooking.Models
//{
//    public class ContactMessage
//    {
//        public int Id { get; set; }

//        [Required]
//        public string Name { get; set; }

//        [Required]
//        public string Email { get; set; }

//        [Required]
//        public string Subject { get; set; }

//        [Required]
//        public string Message { get; set; }

//        public DateTime CreatedAt { get; set; } = DateTime.Now;
//        public string Status { get; set; } = "Pending";
//    }
//}

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HotelBooking.Models
{
    [Table("ContactMessages")]
    public class ContactMessage
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; } = string.Empty;

        [Required]
        [StringLength(150)]
        public string Email { get; set; } = string.Empty;

        [Required]
        [StringLength(200)]
        public string Subject { get; set; } = string.Empty;

        [Required]
        public string Message { get; set; } = string.Empty;

        public DateTime CreatedAt { get; set; }

        public string? Status { get; set; }
    }
}