using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using JapTask1BackendCorrection.Core.Interfaces.RatingService;
using JapTask1BackendCorrection.Core.Response;
using JapTask1BackendCorrection.Infrastructure.Data;
using JapTask1BackendCorrection.Core.Requests.Rating;

namespace JapTask1BackendCorrection.Infrastructure.Services.RatingService
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
        public async Task<ServiceResponse<bool>> AddRating(AddRatingRequest request, int userId)
        {
            // checking if the given video exists, if not return error
            if (await _context.Medias.FirstOrDefaultAsync(x => x.Id == request.MediaId) == null)
                return new() { Message = "The given video does not exist!" };

            if(await _context.Users.FirstOrDefaultAsync(x => x.Id == userId) == null)
                return new() { Message = "The given user does not exist!" };

            // checking if the user already rated the given movie, if he/she/they did then return error
            if (await _context.Ratings.FirstOrDefaultAsync(x => x.UserId == userId && x.MediaId == request.MediaId) != null)
                return new() { Message = "You already rated this item!" };

            // adding rating
            await _context.Ratings.AddAsync(new() { Value = request.Value, MediaId = request.MediaId, UserId = userId });
            await _context.SaveChangesAsync();

            return new() { Data = true, Success = true, Message = "Successfully added rating" };
        }
    }
}
