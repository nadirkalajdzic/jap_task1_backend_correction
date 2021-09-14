using AutoMapper;
using jap_task1_backend_correction.DTO.Actor;
using jap_task1_backend_correction.DTO.Category;
using jap_task1_backend_correction.DTO.Rating;
using jap_task1_backend_correction.DTO.Video;
using jap_task1_backend_correction.Models;

namespace jap_task1_backend_correction
{
    public class AutoMapperProfile: Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Video, GetVideoDTO>();
            CreateMap<Rating, GetRatingOnlyDTO>();
            CreateMap<Actor, GetActorForVideoDTO>();
            CreateMap<Category, GetCategoryForVideoDTO>();
            CreateMap<Video, GetVideoFullInfoDTO>();
            CreateMap<Video, GetVideoTextAttributesDTO>();
        }
    }
}
