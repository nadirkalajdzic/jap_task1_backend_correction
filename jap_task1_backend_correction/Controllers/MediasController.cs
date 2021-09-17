using JapTask1BackendCorrection.DTO.Helpers;
using JapTask1BackendCorrection.DTO.Media;
using JapTask1BackendCorrection.Entities;
using JapTask1BackendCorrection.Services.MediaService;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace JapTask1BackendCorrection.Controllers
{
    [ApiController]
    [Route("api/medias")]
    public class MediasController : ControllerBase
    {

        private readonly IMediaService _videosService;

        public MediasController(IMediaService videosService)
        {
            _videosService = videosService;
        }

        [HttpGet]
        public async Task<ActionResult<ServiceResponse<List<GetMediaDTO>>>> GetMedias([FromQuery] MediaTypeDTO videoTypeDTO, [FromQuery] PaginationDTO paginationDTO)
        {
            var serviceResponse = await _videosService.GetMedias(videoTypeDTO.MediaType, paginationDTO);
            
            return (serviceResponse.Success) ? Ok(serviceResponse) : BadRequest(serviceResponse);
        }

        [HttpGet("{Id}")]
        public async Task<ActionResult<ServiceResponse<List<GetMediaFullInfoDTO>>>> GetMedia(int id)
        {
            var serviceResponse = await _videosService.GetMedia(id);
            return (serviceResponse.Success) ? Ok(serviceResponse) : BadRequest(serviceResponse);
        }

        [HttpGet("filter")]
        public async Task<ActionResult<ServiceResponse<List<GetMediaTextAttributesDTO>>>> GetFilteredMedias([FromQuery] string search = null)
        {
            if (search == null) return Ok(await _videosService.GetMedias(0, new()));

            return Ok(await _videosService.GetFilteredMedias(search));
        }

    }
}
