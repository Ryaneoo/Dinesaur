using System.ComponentModel.DataAnnotations;

namespace Dinesaur.Domain
{
    public class Review
    {
        [Required]
        public string? ReviewTitle {get; set; }
        public int ReviewID {get; set; }
        public DateTime Date { get; set; }
        [Required]
        public double Rating { get; set; }
        [Required]
        public string? Description { get; set; }
        public int RestaurantID { get; set; } /*Foreign key*/
        public string? CustomerID { get; set; } /*Foreign key*/
        public enum ApprovalStatusReviews
        {
            Published = 0,
            Reported = 1,
            Removed = 2
        }
        public ApprovalStatusReviews Status { get; set; } = ApprovalStatusReviews.Published;
    }
}
