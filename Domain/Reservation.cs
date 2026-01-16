using System.ComponentModel.DataAnnotations;

namespace Dinesaur.Domain
{
    public class Reservation : IValidatableObject
    {
        public int ReservationID { get; set; }

        [Required(ErrorMessage = "Booking date is required")]
        public DateTime? Date { get; set; }

        [Required(ErrorMessage = "Booking time is required")]
        public TimeOnly? Time { get; set; }

        [Required(ErrorMessage = "PAX is required")]
        [Range(1, 20, ErrorMessage = "PAX must be between 1 and 20")]
        public int? Pax { get; set; }
        public string? Remarks { get; set; }

        [Required]
        public string CustomerID { get; set; } = string.Empty;

        [Required]
        public int RestaurantID { get; set; }

        public int? ReviewID { get; set; }

        public ReservationStatus Status { get; set; } = ReservationStatus.Pending;

        public enum ReservationStatus
        {
            Pending = 0,
            Confirmed = 1,
            Ongoing = 2,
            Completed = 3,
            Cancelled = 4,
            Absent = 5
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext context)
        {
            if (Date.HasValue && Time.HasValue)
            {
                var combined =
                    Date.Value.Date.Add(Time.Value.ToTimeSpan());

                if (combined <= DateTime.Now)
                {
                    yield return new ValidationResult(
                        "Reservation must be in the future",
                        new[] { nameof(Date), nameof(Time) });
                }
            }
        }
    }
}
