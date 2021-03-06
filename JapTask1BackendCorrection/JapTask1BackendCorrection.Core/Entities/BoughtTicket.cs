using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace JapTask1BackendCorrection.Core.Entities
{
    public class BoughtTicket: BaseEntity, IValidatableObject
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Screening id is required")]
        public int ScreeningId { get; set; }

        [Required(ErrorMessage = "User id is required")]
        public int UserId { get; set; }

        [Required(ErrorMessage = "Bought tickets is required")]
        public int BoughtTickets { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (BoughtTickets < 1)
                yield return new ValidationResult("Need at least one bought ticket!", new[] { "Bought ticket entity" });
        }
    }
}
