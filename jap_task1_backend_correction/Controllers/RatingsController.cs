using jap_task1_backend_correction.DTO.Rating;
using jap_task1_backend_correction.Services.RatingsService;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace jap_task1_backend_correction.Controllers
{
    [Authorize]
    [Route("ratings")]
    [ApiController]
    public class RatingsController : ControllerBase
    {
        private readonly IRatingsService _ratingsService;

        public RatingsController(IRatingsService ratingsService) 
        {

            _ratingsService = ratingsService;

        }

        [HttpPost("add")]
        public async Task<IActionResult> AddRating(AddRatingDTO addRating)
        {
            var response = await _ratingsService.AddRating(addRating.Value, addRating.VideoId);
            
            if (!response.Success)
                return BadRequest(response);

            return Ok(response);
        }
    }
}
