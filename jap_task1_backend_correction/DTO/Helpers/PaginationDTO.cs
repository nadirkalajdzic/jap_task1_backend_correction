using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace JapTask1BackendCorrection.DTO.Helpers
{
    public class PaginationDTO: IValidatableObject
    {
        [Required(ErrorMessage = "Page number is required")]
        public int PageNumber { get; set; } = 1;

        [Required(ErrorMessage = "Page size number is required")]
        public int PageSize { get; set; } = 10;

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (PageNumber < 1)
                yield return new ValidationResult("Page number must be 1 or higher");

            if(PageSize < 1 || PageSize > 100)
                yield return new ValidationResult("Page size must be at least 1 and lower than 100");
        }
    }
}
