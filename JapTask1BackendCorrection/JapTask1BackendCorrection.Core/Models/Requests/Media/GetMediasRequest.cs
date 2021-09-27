using JapTask1BackendCorrection.Core.Models;
using System.ComponentModel.DataAnnotations;

namespace JapTask1BackendCorrection.Core.Requests.Media
{
    public class GetMediasRequest
    {
        [Required(ErrorMessage = "Type of media is required")]
        public MediaEnum MediaType { get; set; } = MediaEnum.Movie;

        [Required(ErrorMessage = "Pagination is required")]
        public Pagination Pagination { get; set; } = new();
    }
}
