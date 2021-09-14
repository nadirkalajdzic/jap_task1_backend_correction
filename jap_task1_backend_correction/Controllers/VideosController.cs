using jap_task1_backend_correction.DTO.Video;
using jap_task1_backend_correction.Models;
using jap_task1_backend_correction.Services.VideosService;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace jap_task1_backend_correction.Controllers
{
    [ApiController]
    [Route("videos")]
    public class VideosController : ControllerBase
    {

        private readonly IVideosService _videosService;

        public VideosController(IVideosService videosService)
        {
            _videosService = videosService;
        }

        [HttpGet("top_movies")]
        public async Task<ActionResult<ServiceResponse<List<GetVideoDTO>>>> GetTopMovies()
        {
            return Ok(await _videosService.GetTopVideos(0));
        }

        [HttpGet("top_movies/top_ten")]
        public async Task<ActionResult<ServiceResponse<List<GetVideoDTO>>>> GetTop10Movies()
        {
            return Ok(await _videosService.GetTop10Videos(0));
        }

        [HttpGet("top_shows")]
        public async Task<ActionResult<ServiceResponse<List<GetVideoDTO>>>> GetTopShows()
        {
            return Ok(await _videosService.GetTopVideos(1));
        }

        [HttpGet("top_shows/top_ten")]
        public async Task<ActionResult<ServiceResponse<List<GetVideoDTO>>>> GetTop10Shows()
        {
            return Ok(await _videosService.GetTop10Videos(1));
        }

        [HttpGet("item/{Id}")]
        public async Task<ActionResult<ServiceResponse<List<GetVideoFullInfoDTO>>>> GetVideo(int Id)
        {
            return Ok(await _videosService.GetVideo(Id));
        }

        [HttpGet]
        public async Task<ActionResult<ServiceResponse<List<GetVideoTextAttributesDTO>>>> GetFilteredVideos([FromQuery] string search = null)
        {
          if (search == null) return Ok(await _videosService.GetTopVideos(0));
          
            return Ok(await _videosService.GetFilteredVideos(search));
        }

    }
}
