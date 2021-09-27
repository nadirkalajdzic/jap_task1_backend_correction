using JapTask1BackendCorrection.Core.DTO.Media;
using JapTask1BackendCorrection.Core.Interfaces.MediaService;
using JapTask1BackendCorrection.Core.Requests.Media;
using JapTask1BackendCorrection.Core.Response;
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
        public async Task<ActionResult<ServiceResponse<List<GetMediaDTO>>>> GetMedias([FromQuery] GetMediasRequest request)
        {
            var serviceResponse = await _videosService.GetMedias(request);
            
            return (serviceResponse.Success) ? Ok(serviceResponse) : BadRequest(serviceResponse);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ServiceResponse<List<GetMediaFullInfoDTO>>>> GetMedia([FromRoute] int id)
        {
            var serviceResponse = await _videosService.GetMedia(id);
            return (serviceResponse.Success) ? Ok(serviceResponse) : BadRequest(serviceResponse);
        }

        [HttpGet("filter")]
        public async Task<ActionResult<ServiceResponse<List<GetMediaTextAttributesDTO>>>> GetFilteredMedias([FromQuery] string search = null)
        {
            if (search == null) return Ok(await _videosService.GetMedias());

            return Ok(await _videosService.GetFilteredMedias(search));
        }

    }
}
