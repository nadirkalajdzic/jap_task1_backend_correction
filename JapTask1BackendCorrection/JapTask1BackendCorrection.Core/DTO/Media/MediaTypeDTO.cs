using JapTask1BackendCorrection.Core.Models;
using System.ComponentModel.DataAnnotations;

namespace JapTask1BackendCorrection.Core.DTO.Media
{

    public class MediaTypeDTO
    {
        [Required(ErrorMessage = "Type of media is required")]
        public MediaEnum MediaType { get; set; } = MediaEnum.Movie;
    }
}
