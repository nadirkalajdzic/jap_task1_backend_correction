using System.ComponentModel.DataAnnotations;

namespace JapTask1BackendCorrection.DTO.User
{
    public class GetUserDTO
    {
        [Required(ErrorMessage = "Token is required")]
        public string Token { get; set; }

        [Required(ErrorMessage = "User's first name is required")]
        [MaxLength(50, ErrorMessage = "User's first name cannot be longer than 50 characters")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "User's last name is required")]
        [MaxLength(50, ErrorMessage = "User's last name cannot be longer than 50 characters")]
        public string LastName { get; set; }
    }
}
