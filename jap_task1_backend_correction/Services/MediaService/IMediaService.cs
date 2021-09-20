using JapTask1BackendCorrection.DTO.Helpers;
using JapTask1BackendCorrection.DTO.Media;
using JapTask1BackendCorrection.Entities;
using JapTask1BackendCorrection.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace JapTask1BackendCorrection.Services.MediaService
{
    public interface IMediaService
    {
        Task<ServiceResponse<List<GetMediaDTO>>> GetMedias(MediaEnum mediaType, Pagination paginationDTO);
        Task<ServiceResponse<GetMediaFullInfoDTO>> GetMedia(int id);
        Task<ServiceResponse<List<GetMediaTextAttributesDTO>>> GetFilteredMedias(string search);
    }
}
