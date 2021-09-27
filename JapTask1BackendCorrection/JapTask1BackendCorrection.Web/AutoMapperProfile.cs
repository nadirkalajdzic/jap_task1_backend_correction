using AutoMapper;
using JapTask1BackendCorrection.Core.DTO.Actor;
using JapTask1BackendCorrection.Core.DTO.Category;
using JapTask1BackendCorrection.Core.DTO.Media;
using JapTask1BackendCorrection.Core.DTO.Rating;
using JapTask1BackendCorrection.Core.Entities;

namespace JapTask1BackendCorrection.Web
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
