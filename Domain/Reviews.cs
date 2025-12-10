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

        public int CustomerID { get; set; } /*Foreign key*/
    }
}
