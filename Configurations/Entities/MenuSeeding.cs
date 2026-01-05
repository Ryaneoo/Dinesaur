using Dinesaur.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Dinesaur.Configurations.Entities
{
    public class MenuSeeding : IEntityTypeConfiguration<Menu>
    {
        public void Configure(EntityTypeBuilder<Menu> builder)
        {
            builder.HasData(
                new Menu
                {
                    MenuID = 1,
                    RestaurantID = 999,
                    Category = "",
                    Catergories = new List<string>()
                },
                new Menu
                {
                    MenuID = 2,
                    RestaurantID = 9998,
                    Category = "",
                    Catergories = new List<string>()
                });

        }
    }
}
