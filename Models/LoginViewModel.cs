//using System.ComponentModel.DataAnnotations;

//namespace HotelBooking.Models
//{
//    public class LoginViewModel
//    {
//        [Required]
//        [EmailAddress]
//        public string Email { get; set; }

//        [Required]
//        public string Password { get; set; }
//    }
//}

using System.ComponentModel.DataAnnotations;

namespace HotelBooking.Models
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Invalid email format")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Password is required")]
        [MinLength(5, ErrorMessage = "Password must be at least 5 characters")]
        public string Password { get; set; }
    }
}
