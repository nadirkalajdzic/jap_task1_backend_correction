using jap_task1_backend_correction.DTO.Helpers;
using jap_task1_backend_correction.DTO.Video;
using jap_task1_backend_correction.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace jap_task1_backend_correction.Services.VideosService
{
    public interface IVideosService
    {
        Task<ServiceResponse<List<GetVideoDTO>>> GetVideos(int type, PaginationDTO paginationDTO);
        Task<ServiceResponse<GetVideoFullInfoDTO>> GetVideo(int Id);
        Task<ServiceResponse<List<GetVideoTextAttributesDTO>>> GetFilteredVideos(string Search);
    }
}
