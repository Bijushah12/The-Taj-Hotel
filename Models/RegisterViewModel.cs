using System.ComponentModel.DataAnnotations;

namespace HotelBooking.Models
{
    public class RegisterViewModel
    {
        [Required]
        public string Username { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }

    }
}
