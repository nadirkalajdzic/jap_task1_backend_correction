using JapTask1BackendCorrection.Models;
using System.ComponentModel.DataAnnotations;

namespace JapTask1BackendCorrection.DTO.Media
{

    public class MediaTypeDTO
    {
        [Required(ErrorMessage = "Type of media is required")]
        public MediaEnum MediaType { get; set; } = MediaEnum.Movie;
    }
}
