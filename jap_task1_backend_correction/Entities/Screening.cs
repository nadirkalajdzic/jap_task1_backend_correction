using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace JapTask1BackendCorrection.Entities
{
    public class Screening : BaseEntity, IValidatableObject
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Screening name is required")]
        [MaxLength(50, ErrorMessage = "Name cannot be longer than 50 characters")]
        public string Name { get; set; }

        [Required(ErrorMessage = "FK Video Id is required")]
        public int MediaId { get; set; }

        [Required(ErrorMessage = "Available tickets field is required")]
        public int AvailableTickets { get; set; }

        [Required(ErrorMessage = "Number of sold tickets is required")]
        public int SoldTickets { get; set; }

        [Required(ErrorMessage = "ScreeningDate is required")]
        public DateTime ScreeningDate { get; set; }

        [Required(ErrorMessage = "Duration is required")]
        public int Duration { get; set; } // duration in minutes
        
        public List<BoughtTicket> BoughtTickets { get; set; } = new List<BoughtTicket>();

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (Duration < 1)
                yield return new ValidationResult("Screening duration cannot be below 1 minute");

            if (AvailableTickets < 1)
                yield return new ValidationResult("There must be at least 1 available ticket or more");

            if (SoldTickets < 0)
                yield return new ValidationResult("Sold tickets number cannot be negative");
        }
    }
}
