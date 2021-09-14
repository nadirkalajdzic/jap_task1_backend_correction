using jap_task1_backend_correction.DTO.Video;
using jap_task1_backend_correction.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace jap_task1_backend_correction.Services.VideosService
{
    public interface IVideosService
    {
        Task<ServiceResponse<List<GetVideoDTO>>> GetTopVideos(int type);
        Task<ServiceResponse<List<GetVideoDTO>>> GetTop10Videos(int type);
        Task<ServiceResponse<GetVideoFullInfoDTO>> GetVideo(int Id);
        Task<ServiceResponse<List<GetVideoTextAttributesDTO>>> GetFilteredVideos(string Search);
    }
}
