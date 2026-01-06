using Dinesaur.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Dinesaur.Configurations.Entities
{
    public class FoodSeeding : IEntityTypeConfiguration<Food>
    {
        

        public void Configure(EntityTypeBuilder<Food> builder)
        {
            builder.HasData(
                new Food
                {
                    FoodID = 1,
                    FoodName = "Chicken",
                    Cost = 3.50,
                    Description = "White meat",
                    StaffID = "999",
                    MenuID = 9999,
                    Category = "Meat",
                    Image = new List<string>()
                },
                new Food
                {
                    FoodID = 2,
                    FoodName = "Fish",
                    Cost = 4.00,
                    Description = "Saba",
                    StaffID = "9999",
                    MenuID = 999,
                    Category = "Seafood",
                    Image = new List<string>()
                });
        }
    }
}
