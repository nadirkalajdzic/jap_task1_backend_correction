using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace JapTask1BackendCorrection.Core.Entities
{
    public class Actor: BaseEntity
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Actor's first name is required")]
        [MaxLength(50, ErrorMessage = "Actor's first name cannot be longer than 50 characters")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Actor's last name is required")]
        [MaxLength(50, ErrorMessage = "Actor's last name cannot be longer than 50 characters")]
        public string LastName { get; set; }

        public List<Media> Medias { get; set; } = new List<Media>();
    }
}
