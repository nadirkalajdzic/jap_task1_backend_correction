using JapTask1BackendCorrection.Data;
using JapTask1BackendCorrection.Entities;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System;

namespace JapTask1BackendCorrection.Services.RatingService
{
    public class RatingService: IRatingService
    {
        private readonly DataContext _context;
        
        public RatingService(DataContext context)
        {
            _context = context;
        }

        public async Task<ServiceResponse<bool>> AddRating(float addValue, int addVideoId, int userId)
        {
            ServiceResponse<bool> response = new() { Data = false };

            if (addValue < 1 || addValue > 5)
               throw new Exception("Rating must be between 1 and 5!");

            // checking if the given video exists, if not return error
            var isVideoExisting = await _context.Medias.FirstOrDefaultAsync(x => x.Id == addVideoId);
            if (isVideoExisting == null)
                throw new Exception("The given video does not exist!");

            // checking if the user already rated the given movie, if he/she/they did then return error
            var userAlreadyAddedRating = await _context.Ratings.FirstOrDefaultAsync(x => x.UserId == userId && x.MediaId == addVideoId);
            if (userAlreadyAddedRating != null)
                throw new Exception("You already rated this item!");

            // adding rating
            await _context.Ratings.AddAsync(new() { Value = addValue, MediaId = addVideoId, UserId = userId });
            await _context.SaveChangesAsync();

            return new() { Data = true, Success = true, Message = "Successfully added rating" };
        }
    }
}
