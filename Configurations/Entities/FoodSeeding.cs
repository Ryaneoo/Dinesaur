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
                    PreOrderID = 1,
                    StaffID = 1,
                    MenuID = 1,
                    Image = new List<string>()
                },
                new Food
                {
                    FoodID = 2,
                    FoodName = "Fish",
                    Cost = 4.00,
                    Description = "Saba",
                    PreOrderID = 2,
                    StaffID = 2,
                    MenuID = 2,
                    Image = new List<string>()
                });
        }
    }
}
