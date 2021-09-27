using System.ComponentModel.DataAnnotations;

namespace JapTask1BackendCorrection.Core.DTO.Media
{
    public class GetMediaTextAttributesDTO
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Title is required")]
        [MaxLength(50, ErrorMessage = "Title cannot be longer than 50 characters")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Description is required")]
        [MaxLength(200, ErrorMessage = "Description cannot be longer than 200 characters")]
        public string Description { get; set; }
    }
}
