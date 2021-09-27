using JapTask1BackendCorrection.Core.DTO.Actor;
using JapTask1BackendCorrection.Core.DTO.Category;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace JapTask1BackendCorrection.Core.DTO.Media
{
    public class GetMediaFullInfoDTO: IValidatableObject
    {

        public int Id { get; set; }

        [Required(ErrorMessage = "Title is required")]
        [MaxLength(50, ErrorMessage = "Title cannot be longer than 50 characters")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Description is required")]
        [MaxLength(200, ErrorMessage = "Description cannot be longer than 200 characters")]
        public string Description { get; set; }

        [Required(ErrorMessage = "ImageUrl is required")]
        [MaxLength(100, ErrorMessage = "Url of image cannot be longer than 100 characters")]
        public string ImageUrl { get; set; }

        [Required(ErrorMessage = "Release date is required")]
        public DateTime ReleaseDate { get; set; }

        [Required(ErrorMessage = "Average rating is required")]
        public float AverageRating { get; set; } = 0;

        public List<GetActorForMediaDTO> Actors { get; set; } = new List<GetActorForMediaDTO>();
        public List<GetCategoryForMediaDTO> Categories { get; set; } = new List<GetCategoryForMediaDTO>();

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (AverageRating < 0 || AverageRating > 5)
                yield return new ValidationResult("Average rating must be between 1 and 5. If there is no rating it should be 0.");
        }
    }
}
