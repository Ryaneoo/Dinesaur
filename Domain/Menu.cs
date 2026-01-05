namespace Dinesaur.Domain
{
    public class Menu
    {
        public int MenuID { get; set; }
        public int RestaurantID { get; set; }
        public string? Category { get; set; }
        public List<string> Catergories { get; set; } = new List<string>();
    }
}
