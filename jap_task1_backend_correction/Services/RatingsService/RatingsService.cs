using jap_task1_backend_correction.Data;
using jap_task1_backend_correction.Models;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Http;
using System.Security.Claims;

namespace jap_task1_backend_correction.Services.RatingsService
{
    public class RatingsService: IRatingsService
    {
        private readonly DataContext _context;
        

        public RatingsService(DataContext context)
        {
            _context = context;
           
        }

        public async Task<ServiceResponse<bool>> AddRating(float AddValue, int AddVideoId, int UserId)
        {

            ServiceResponse<bool> response = new();

            response.Data = false;
            response.Success = false;

            if (AddValue < 1 || AddValue > 5)
            {
                response.Message = "Rating must be between 1 and 5!";
                return response;
            }

            var isVideoExisting = await _context.Videos.FirstOrDefaultAsync(x => x.Id == AddVideoId);

            if(isVideoExisting == null)
            {
                response.Message = "The given video does not exist!";
                return response;
            }

            var userAlreadyAddedRating = await _context.Ratings.FirstOrDefaultAsync(x => x.UserId == UserId && x.VideoId == AddVideoId);

            if(userAlreadyAddedRating != null)
            {
                response.Message = "You already rated this item!";
                return response;
            }

            var addRating = new Rating
            {
                Value = AddValue,
                VideoId = AddVideoId,
                UserId = UserId
            };

            await _context.Ratings.AddAsync(addRating);
            await _context.SaveChangesAsync();

            response.Data = true;
            response.Success = true;
            response.Message = "Successfully added rating";

            return response;
        }

    }
}
