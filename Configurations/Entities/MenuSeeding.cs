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
                    RestaurantID = 1
                },
                new Menu
                {
                    MenuID = 2,
                    RestaurantID = 2
                });

        }
    }
}
