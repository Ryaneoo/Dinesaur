using Dinesaur.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Dinesaur.Configurations.Entities
{
    public class RestaurantSeeding : IEntityTypeConfiguration<Restaurant>
    {
        public void Configure(EntityTypeBuilder<Restaurant> builder)
        {
            builder.HasData(
                new Restaurant
                {
                    RestaurantID = 1,
                    RestaurantName = "WesternBanana",
                    Location = "Orchard",
                    Category = "Western",
                    AdminID = 1,
                    Logo = new List<string>(),
                    RestaurantOwnerID = "3"
                });
        }
    }
}
