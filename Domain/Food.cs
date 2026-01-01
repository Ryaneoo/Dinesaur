namespace Dinesaur.Domain
{
    public class Food
    {   
        public int FoodID { get; set; }

        public string? FoodName { get; set; }

        public double Cost { get; set; }

        public string? Description { get; set; } 

        public int PreOrderID { get; set; }

        public int StaffID { get; set; }

        public int MenuID { get; set; }

        public List<string> Image { get; set; } = new List<string>();
    }
}
