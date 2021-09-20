using JapTask1BackendCorrection.DTO.Helpers;
using JapTask1BackendCorrection.Models;
using System.ComponentModel.DataAnnotations;

namespace JapTask1BackendCorrection.Requests.Media
{
    public class GetMediasRequest
    {
        [Required(ErrorMessage = "Type of media is required")]
        public MediaEnum MediaType { get; set; } = MediaEnum.Movie;

        [Required(ErrorMessage = "Pagination is required")]
        public Pagination Pagination { get; set; }
    }
}
