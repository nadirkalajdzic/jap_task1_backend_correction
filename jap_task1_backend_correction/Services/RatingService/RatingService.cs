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

        /// <summary>
        ///     adds a rating for the movie/show, 
        ///     firstly its checked if a valid rating is given (between 1 and 5),
        ///     then if the given id is correct (if the movie/show exists) and then 
        ///     if the user exists (is in the database) and then
        ///     if the given user already rated the movie/show.
        ///     if any of the conditions isn't met an exception is thrown, elsewise
        ///     the ratings is added
        /// </summary>
        /// <param name="addValue"> value of the rating that will be added, must be between 1 and 5 </param>
        /// <param name="addMediaId"> id of the movie/show that will be rated, must be in the database </param>
        /// <param name="userId"> id of the user that is rating the movie/show, must be in the database </param>
        /// <returns> will basically always return true because if the conditions aren't met an exception is thrown </returns>
        public async Task<ServiceResponse<bool>> AddRating(float addValue, int addMediaId, int userId)
        {
            ServiceResponse<bool> response = new() { Data = false };

            if (addValue < 1 || addValue > 5)
               throw new Exception("Rating must be between 1 and 5!");

            // checking if the given video exists, if not return error
            if (await _context.Medias.FirstOrDefaultAsync(x => x.Id == addMediaId) == null)
                throw new Exception("The given video does not exist!");

            if(await _context.Users.FirstOrDefaultAsync(x => x.Id == userId) == null)
                throw new Exception("The given user does not exist!");

            // checking if the user already rated the given movie, if he/she/they did then return error
            if (await _context.Ratings.FirstOrDefaultAsync(x => x.UserId == userId && x.MediaId == addMediaId) != null)
                throw new Exception("You already rated this item!");

            // adding rating
            await _context.Ratings.AddAsync(new() { Value = addValue, MediaId = addMediaId, UserId = userId });
            await _context.SaveChangesAsync();

            return new() { Data = true, Success = true, Message = "Successfully added rating" };
        }
    }
}
