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

        public async Task<ServiceResponse<List<GetMediaDTO>>> GetMedias(MediaEnum mediaType, PaginationDTO paginationDTO)
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

        public async Task<ServiceResponse<GetMediaFullInfoDTO>> GetMedia(int Id)
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
                                     .FirstOrDefaultAsync(x => x.Id == Id) ?? throw new Exception("Movie not found"),

                Message = "Success",
                Success = true
            };
        }

        public async Task<ServiceResponse<List<GetMediaTextAttributesDTO>>> GetFilteredMedias(string Search)
        {
            var query = _context.Medias.AsQueryable();
            AddFiltersForVideoSearch(Search, ref query);

            return new()
            {
                Data = await query.OrderByDescending(x => x.Ratings.Select(x => x.Value)
                                                                   .DefaultIfEmpty()
                                                                   .Average())
                                  .Select(x => _mapper.Map<GetMediaTextAttributesDTO>(x))
                                  .ToListAsync(),
                Message = "Success",
                Success = true
            };
        }

        private static void AddFiltersForVideoSearch(string Search, ref IQueryable<Media> query)
        {

            var searchQuery = Regex.Split(Search, @"\s+").ToList();

            // ------ helper functions to make the code cleaner ------
            void setDefaultSearchQuery(ref IQueryable<Media> q) => q = q.Where(x => x.Title.ToUpper().Contains(Search.ToUpper())
                                                                   || x.Description.ToUpper().Contains(Search.ToUpper()));

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
