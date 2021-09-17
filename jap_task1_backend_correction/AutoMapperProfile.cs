using AutoMapper;
using JapTask1BackendCorrection.DTO.Actor;
using JapTask1BackendCorrection.DTO.Category;
using JapTask1BackendCorrection.DTO.Media;
using JapTask1BackendCorrection.DTO.Rating;
using JapTask1BackendCorrection.Entities;

namespace JapTask1BackendCorrection
{
    public class AutoMapperProfile: Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Media, GetMediaDTO>();
            CreateMap<Rating, GetRatingOnlyDTO>();
            CreateMap<Actor, GetActorForMediaDTO>();
            CreateMap<Category, GetCategoryForMediaDTO>();
            CreateMap<Media, GetMediaFullInfoDTO>();
            CreateMap<Media, GetMediaTextAttributesDTO>();
        }
    }
}
