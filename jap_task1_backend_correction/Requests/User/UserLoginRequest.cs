using System.ComponentModel.DataAnnotations;

namespace JapTask1BackendCorrection.DTO.User
{
    public class UserLoginRequest
    {
        [Required(ErrorMessage = "Email is required")]
        [MaxLength(30, ErrorMessage = "Email cannot be longer than 30 characters")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Password is required")]
        [MaxLength(20, ErrorMessage = "Password cannot be longer than 20 characters")]
        public string Password { get; set; }
    }
}
