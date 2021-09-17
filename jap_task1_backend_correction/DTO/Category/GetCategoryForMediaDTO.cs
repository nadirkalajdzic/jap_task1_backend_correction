using System.ComponentModel.DataAnnotations;

namespace JapTask1BackendCorrection.DTO.Category
{
    public class GetCategoryForMediaDTO
    {
        [Required(ErrorMessage = "Category name is required")]
        [MaxLength(50, ErrorMessage = "Category name cannot be longer than 50 characters")]
        public string Name { get; set; }
    }
}
