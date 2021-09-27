using JapTask1BackendCorrection.Core.DTO.Media;
using JapTask1BackendCorrection.Core.Models;
using JapTask1BackendCorrection.Core.Requests.Media;
using JapTask1BackendCorrection.Core.Response;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace JapTask1BackendCorrection.Core.Interfaces.MediaService
{
    public interface IMediaService
    {
        Task<ServiceResponse<List<GetMediaDTO>>> GetMedias(GetMediasRequest request = null);
        Task<ServiceResponse<GetMediaFullInfoDTO>> GetMedia(int id);
        Task<ServiceResponse<List<GetMediaTextAttributesDTO>>> GetFilteredMedias(string search);
    }
}
