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
                    OpeningHours = new TimeOnly(9, 0),
                    ClosingHours = new TimeOnly(22, 0),
                    
                    RestaurantOwnerID = "3",
                    Logo = ["/Images/DinesaurLandingPage.jpg"],
                    
                    Contact = 12340987,
                    Email = "seededRest@gmail.com",
                    Status = Restaurant.ApprovalStatus.Approved
                });
        }
    }
}
