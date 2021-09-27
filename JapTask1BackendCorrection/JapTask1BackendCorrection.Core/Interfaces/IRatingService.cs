using JapTask1BackendCorrection.Core.Requests.Rating;
using JapTask1BackendCorrection.Core.Response;
using System.Threading.Tasks;

namespace JapTask1BackendCorrection.Core.Interfaces.RatingService
{
    public interface IRatingService
    {
        Task<ServiceResponse<bool>> AddRating(AddRatingRequest request, int userId);
    }
}
