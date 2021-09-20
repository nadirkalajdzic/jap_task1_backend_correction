using AutoMapper;
using JapTask1BackendCorrection.Data;
using JapTask1BackendCorrection.DTO.Actor;
using JapTask1BackendCorrection.DTO.Category;
using JapTask1BackendCorrection.DTO.Helpers;
using JapTask1BackendCorrection.DTO.Media;
using JapTask1BackendCorrection.Entities;
using JapTask1BackendCorrection.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace JapTask1BackendCorrection.Services.MediaService
{
    public class MediaService : IMediaService
    {
        private readonly IMapper _mapper;
        private readonly DataContext _context;

        public MediaService(IMapper mapper, DataContext context)
        {
            _mapper = mapper;
            _context = context;
        }

        /// <summary>
        ///     checks firstly if the given parameters 
        ///     for the pagination are correct, if they are
        ///     returns the list of movies/shows
        /// </summary>
        /// <param name="mediaType">if it is a show or a movie</param>
        /// <param name="paginationDTO">which page it is and the page size</param>
        /// <returns> list of movies/shows with basic data </returns>
        public async Task<ServiceResponse<List<GetMediaDTO>>> GetMedias(MediaEnum mediaType, Pagination paginationDTO)
        {
            if(paginationDTO.PageNumber < 1 || paginationDTO.PageSize < 1)
               throw new Exception("Incorrect paramteres for the pagination");

            var serviceResponse = new ServiceResponse<List<GetMediaDTO>>
            {
                Data = await _context.Medias
                                     .Include(x => x.Ratings)
                                     .Where(x => x.Type == mediaType)
                                     .Select(x => new GetMediaDTO
                                     {
                                         Id = x.Id,
                                         Title = x.Title,
                                         Description = x.Description,
                                         ImageUrl = x.ImageUrl,
                                         ReleaseDate = x.ReleaseDate,
                                         AverageRating = x.Ratings.Select(x => x.Value)
                                                                  .DefaultIfEmpty()
                                                                  .Average()
                                     })
                                     .OrderByDescending(x => x.AverageRating)
                                     .Skip((paginationDTO.PageNumber - 1) * paginationDTO.PageSize)
                                     .Take(paginationDTO.PageSize)
                                     .ToListAsync(),
                Message = "Success",
                Success = true
            };

            return serviceResponse;
        }

        /// <summary>
        ///     returns the specific movie/show for the given id
        /// </summary>
        /// <param name="id">id of the movie</param>
        /// <returns> movie/show for the given id or throws an exception if the movie for the id doesn't exist </returns>
        public async Task<ServiceResponse<GetMediaFullInfoDTO>> GetMedia(int id)
        {
            return new ServiceResponse<GetMediaFullInfoDTO>
            {
                Data = await _context.Medias
                                     .Include(x => x.Actors).AsSingleQuery()
                                     .Include(x => x.Categories).AsSingleQuery()
                                     .Include(x => x.Ratings).AsSingleQuery()
                                     .Select(x => new GetMediaFullInfoDTO
                                     {
                                         Id = x.Id,
                                         Title = x.Title,
                                         Description = x.Description,
                                         ImageUrl = x.ImageUrl,
                                         ReleaseDate = x.ReleaseDate,
                                         AverageRating = x.Ratings.Select(x => x.Value).DefaultIfEmpty().Average(),
                                         Actors = x.Actors.Select(x => new GetActorForMediaDTO { FirstName = x.FirstName, LastName = x.LastName }).ToList(),
                                         Categories = x.Categories.Select(x => new GetCategoryForMediaDTO { Name = x.Name }).ToList()
                                     })
                                     .FirstOrDefaultAsync(x => x.Id == id) ?? throw new Exception("Movie not found"),

                Message = "Success",
                Success = true
            };
        }

        /// <summary>
        ///     the AddFiltersForVideoSearch method
        ///     prepares the query before it gets executed and
        ///     returns a list of movies/shows --> check the AddFiltersForVideoSearch below
        ///                                        to see the logic 
        /// </summary>
        /// <param name="search">search query, can be any of the movie/show attributes or special frazes like 'at least 4.4 stars' </param>
        /// <returns> list of movies/shows filtered by the search string </returns>
        public async Task<ServiceResponse<List<GetMediaTextAttributesDTO>>> GetFilteredMedias(string search)
        {
            var query = _context.Medias.AsQueryable();
            AddFiltersForVideoSearch(search, ref query);

            return new()
            {
                Data = await query.OrderByDescending(x => x.Ratings.Select(x => x.Value)
                                                                   .DefaultIfEmpty()
                                                                   .Average())
                                  .Take(100)
                                  .Select(x => _mapper.Map<GetMediaTextAttributesDTO>(x))
                                  .ToListAsync(),
                Message = "Success",
                Success = true
            };
        }


        /// <summary>
        ///     firstly, the search query gets split in arrays of string
        ///     and checks firstly if the special frazes are given 
        ///     like 'after 2015', 'at least 4.4 stars' and etc.
        ///     If they are, a special query is prepared, elsewise the films/shows are 
        ///     searched in the sense if their textual attributes contain the given search string
        /// </summary>
        /// <param name="search"> the search query </param>
        /// <param name="query"> the query that will be materialized </param>
        private static void AddFiltersForVideoSearch(string search, ref IQueryable<Media> query)
        {

            var searchQuery = Regex.Split(search, @"\s+").ToList();

            // ------ helper functions to make the code cleaner ------
            void setDefaultSearchQuery(ref IQueryable<Media> q) => q = q.Where(x => x.Title.ToUpper().Contains(search.ToUpper())
                                                                   || x.Description.ToUpper().Contains(search.ToUpper()));

            bool containingStringStar(string s) => s.ToUpper().Equals("STAR") || s.ToUpper().Equals("STARS");
            bool containingStringYear(string s) => s.ToUpper().Equals("YEAR") || s.ToUpper().Equals("YEARS");
            // -------------------------------------------------------

            if (searchQuery.Count < 2)
                setDefaultSearchQuery(ref query);
            else
            {
                if (searchQuery.Count == 2)
                {
                    if (searchQuery[0].ToUpper().Equals("AFTER") && int.TryParse(searchQuery[1], out int ratingForSearchAfter))
                        query = query.Where(x => x.ReleaseDate.Year > ratingForSearchAfter);
                    else if (containingStringStar(searchQuery[1]) && float.TryParse(searchQuery[0], out float exactRating))
                        query = query.Where(x => x.Ratings.Select(x => x.Value).Average() == exactRating);
                    else setDefaultSearchQuery(ref query);
                }
                else if (searchQuery.Count == 4)
                {
                    if (searchQuery[0].ToUpper().Equals("AT") && searchQuery[1].ToUpper().Equals("LEAST")
                     && float.TryParse(searchQuery[2], out float ratingForSearchAtLeast)
                     && containingStringStar(searchQuery[3]))
                    {
                        query = query.Where(x => x.Ratings.Select(x => x.Value).Average() >= ratingForSearchAtLeast);
                    }
                    else if (searchQuery[0].ToUpper().Equals("OLDER") && searchQuery[1].ToUpper().Equals("THAN")
                          && int.TryParse(searchQuery[2], out int dateForSearchOlderThan)
                          && containingStringYear(searchQuery[3]))
                    {
                        query = query.Where(x => DateTime.Now.Year - x.ReleaseDate.Year > dateForSearchOlderThan);
                    }
                    else setDefaultSearchQuery(ref query);
                }
                else setDefaultSearchQuery(ref query);
            }
        }
    }
}
