using System.ComponentModel.DataAnnotations;

namespace HotelBooking.Models
{
    public class AdminLoginViewModel
    {
        [Required(ErrorMessage = "Username is required")]
        [MinLength(3, ErrorMessage = "Username must be at least 3 characters")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Password is required")]
        [MinLength(5, ErrorMessage = "Password must be at least 5 characters")]
        public string Password { get; set; }

        public bool RememberMe { get; set; }
    }
}
