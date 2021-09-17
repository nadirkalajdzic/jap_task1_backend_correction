using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace JapTask1BackendCorrection.Entities
{
    public class Category
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Category name is required")]
        [MaxLength(50, ErrorMessage = "Category name cannot be longer than 50 characters")]
        public string Name { get; set; }

        public List<Media> Medias { get; set; } = new List<Media>();
    }
}
