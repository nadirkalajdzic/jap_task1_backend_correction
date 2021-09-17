using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace JapTask1BackendCorrection.DTO.Rating
{
    public class AddRatingDTO: IValidatableObject
    {
        [Required(ErrorMessage = "Rating value is required")]
        public float Value { get; set; }

        [Required(ErrorMessage = "Id of video must be given")]
        public int VideoId { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (Value < 1 || Value > 5)
                yield return new ValidationResult("Rating value must be between 1 and 5");
        }
    }
}
