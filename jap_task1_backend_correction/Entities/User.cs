using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace JapTask1BackendCorrection.Entities
{
    public class User : BaseEntity
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "First name is required")]
        [MaxLength(50, ErrorMessage = "First name cannot be longer than 50 characters")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Last name is required")]
        [MaxLength(50, ErrorMessage = "Last name cannot be longer than 50 characters")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Email is required")]
        [MaxLength(30, ErrorMessage = "Email cannot be longer than 30 characters")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Salt is required")]
        public byte[] Salt { get; set; }

        [Required(ErrorMessage = "Hash is required")]
        public byte[] Hash { get; set; }

        public List<Rating> Ratings { get; set; } = new List<Rating>();
        public List<BoughtTicket> BoughtTickets { get; set; } = new List<BoughtTicket>();
    }
}
