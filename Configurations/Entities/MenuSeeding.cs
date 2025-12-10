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
                    Cost = 3.50,
                    FoodID = 1,
                    ReservationID = 1
                },
                new Menu
                {
                    MenuID = 2,
                    Cost = 4,
                    FoodID = 2,
                    ReservationID = 2
                });

        }
    }
}
