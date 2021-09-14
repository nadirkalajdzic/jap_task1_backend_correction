using jap_task1_backend_correction.Models;
using System.Threading.Tasks;

namespace jap_task1_backend_correction.Services.RatingsService
{
    public interface IRatingsService
    {
        Task<ServiceResponse<bool>> AddRating(float Value, int VideoId);
    }
}
