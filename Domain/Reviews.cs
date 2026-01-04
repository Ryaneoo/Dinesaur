namespace Dinesaur.Domain
{
    public class Review
    {
        public string? ReviewTitle {get; set; }
        public int ReviewID {get; set; }
        public string? Location { get; set; }
        
        public DateTime Date { get; set; }
        public double Rating { get; set; }
        public string? Description { get; set; }
        public int RestaurantID { get; set; } /*Foreign key*/

        public int Id { get; set; } /*Foreign key*/

        public enum ApprovalStatusReviews
        {
            Pending = 0,
            Approved = 1,
            Rejected = 2
        }

        public ApprovalStatusReviews Status { get; set; } = ApprovalStatusReviews.Pending;
    }
}
