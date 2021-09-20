using JapTask1BackendCorrection.Entities;
using System.Threading.Tasks;

namespace JapTask1BackendCorrection.Services.RatingService
{
    public interface IRatingService
    {
        Task<ServiceResponse<bool>> AddRating(float addValue, int addMediaId, int userId);
    }
}
