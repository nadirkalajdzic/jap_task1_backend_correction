using jap_task1_backend_correction.DTO.Rating;
using jap_task1_backend_correction.Services.RatingsService;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using System.Threading.Tasks;

namespace jap_task1_backend_correction.Controllers
{
    [Authorize]
    [Route("api/ratings")]
    [ApiController]
    public class RatingsController : ControllerBase
    {
        private readonly IRatingsService _ratingsService;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public RatingsController(IRatingsService ratingsService, IHttpContextAccessor httpContextAccessor) 
        {
            _ratingsService = ratingsService;
            _httpContextAccessor = httpContextAccessor;
        }

        private int GetUserId() => int.Parse(_httpContextAccessor.HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier));

        [HttpPost("add")]
        public async Task<IActionResult> AddRating(AddRatingDTO addRating)
        {
            var response = await _ratingsService.AddRating(addRating.Value, addRating.VideoId, GetUserId());
            
            return (response.Success) ? Ok(response) : BadRequest(response);
        }
    }
}
