using System.ComponentModel.DataAnnotations;

namespace Dinesaur.Domain
{
    public class Restaurant : BaseDomainModel
    {
        public int RestaurantID { get; set; }

        [Required]
        public string? RestaurantName { get; set; }
        [Required]
        public string? Location { get; set; }

        [Required]
        public string? Category { get; set; }

        public int AdminID { get; set; }
        [Required]
        public List<string> Logo { get; set; } = new List<string>();
        [Required]
        public TimeOnly OpeningHours { get; set; }
        [Required]
        public TimeOnly ClosingHours { get; set; }

        public string? RestaurantOwnerID { get; set; }

        public enum ApprovalStatus
        {
            Pending = 0,
            Approved = 1,
            Rejected = 2,
        }
        public ApprovalStatus Status { get; set; } = ApprovalStatus.Pending;
    }
}
