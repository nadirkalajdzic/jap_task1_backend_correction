using System.ComponentModel.DataAnnotations;

namespace JapTask1BackendCorrection.Core.Requests.User
{
    public class UserRegisterRequest
    {
        [Required(ErrorMessage = "User's first name is required")]
        [MaxLength(50, ErrorMessage = "User's first name cannot be longer than 50 characters")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "User's last name is required")]
        [MaxLength(50, ErrorMessage = "User's last name cannot be longer than 50 characters")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Email is required")]
        [MaxLength(30, ErrorMessage = "Email cannot be longer than 30 characters")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Password is required")]
        [MaxLength(20, ErrorMessage = "Password cannot be longer than 20 characters")]
        public string Password { get; set; }
    }
}
