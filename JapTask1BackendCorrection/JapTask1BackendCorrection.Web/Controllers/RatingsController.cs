using JapTask1BackendCorrection.Core.Interfaces.RatingService;
using JapTask1BackendCorrection.Core.Requests.Rating;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using System.Threading.Tasks;

namespace JapTask1BackendCorrection.Controllers
{
    [Authorize]
    [Route("api/ratings")]
    [ApiController]
    public class RatingsController : ControllerBase
    {
        private readonly IRatingService _ratingsService;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public RatingsController(IRatingService ratingsService, IHttpContextAccessor httpContextAccessor) 
        {
            _ratingsService = ratingsService;
            _httpContextAccessor = httpContextAccessor;
        }

        private int GetUserId() => int.Parse(_httpContextAccessor.HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier));

        [HttpPost("add")]
        public async Task<IActionResult> AddRating(AddRatingRequest request)
        {
            var response = await _ratingsService.AddRating(request, GetUserId());
            
            return (response.Success) ? Ok(response) : BadRequest(response);
        }
    }
}
