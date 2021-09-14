using jap_task1_backend_correction.DTO.Helpers;
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
        public async Task<ActionResult<ServiceResponse<List<GetVideoDTO>>>> GetTopMovies([FromQuery] PaginationDTO paginationDTO)
        {
            var serviceResponse = await _videosService.GetTopVideos(0, paginationDTO);
            return (serviceResponse.Success) ? Ok(serviceResponse) : BadRequest(serviceResponse);
        }

        [HttpGet("top_shows")]
        public async Task<ActionResult<ServiceResponse<List<GetVideoDTO>>>> GetTopShows([FromQuery] PaginationDTO paginationDTO)
        {
            var serviceResponse = await _videosService.GetTopVideos(1, paginationDTO);
            return (serviceResponse.Success) ? Ok(serviceResponse) : BadRequest(serviceResponse);
        }

        [HttpGet("item/{Id}")]
        public async Task<ActionResult<ServiceResponse<List<GetVideoFullInfoDTO>>>> GetVideo(int Id)
        {
            var serviceResponse = await _videosService.GetVideo(Id);
            return (serviceResponse.Success) ? Ok(serviceResponse) : BadRequest(serviceResponse);
        }

        [HttpGet]
        public async Task<ActionResult<ServiceResponse<List<GetVideoTextAttributesDTO>>>> GetFilteredVideos([FromQuery] string search = null)
        {
          if (search == null) return Ok(await _videosService.GetTopVideos(0, new()));
          
            return Ok(await _videosService.GetFilteredVideos(search));
        }

    }
}
