namespace Dinesaur.Domain
{
    public class Restaurant:BaseDomainModel
    {
        public int RestaurantId { get; set; }

        public string? RestaurantName { get; set; }
        public string? Location { get; set; }
        

        public string? Category { get; set; }

        public int AdminID { get; set; }
    }
}
