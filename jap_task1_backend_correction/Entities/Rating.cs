using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace JapTask1BackendCorrection.Entities
{
    public class Rating: BaseEntity, IValidatableObject
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "A rating is required!")]
        public float Value { get; set; }

        [Required(ErrorMessage = "Video id is required!")]
        public int MediaId { get; set; }

        [Required(ErrorMessage = "User id is required!")]
        public int UserId { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (Value < 1 || Value > 5)
                yield return new ValidationResult("Rating must be between 1 and 5");
        }
    }
}
