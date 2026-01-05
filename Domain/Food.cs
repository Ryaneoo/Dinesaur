using System.ComponentModel.DataAnnotations;

namespace Dinesaur.Domain
{
    public class Food
    {   
        public int FoodID { get; set; }
        [Required]
        public string? FoodName { get; set; }
        [Required]
        public double Cost { get; set; }
        [Required]
        public string? Description { get; set; }
        [Required]
        public string? Category { get; set; }

        public int StaffID { get; set; }

        public int MenuID { get; set; }
        [Required]
        public List<string> Image { get; set; } = new List<string>();
    }
}
