using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace JapTask1BackendCorrection.Core.DTO.Rating
{
    public class GetRatingOnlyDTO: IValidatableObject
    {
        [Required(ErrorMessage = "Rating value is required")]
        public float Value { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (Value < 1 || Value > 5)
                yield return new ValidationResult("Rating must be between 1 and 5");
        }
    }
}
