using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace JapTask1BackendCorrection.Core.Requests.Ticket
{
    public class BuyTicketRequest: IValidatableObject
    {
        [Required(ErrorMessage = "Screening id is required")]
        public int ScreeningId { get; set; }

        [Required(ErrorMessage = "Ticket number is required")]
        public int NumberOfTickets { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (NumberOfTickets < 1)
                yield return new ValidationResult("Number of tickets must be at least 1 or more");
        }
    }
}
