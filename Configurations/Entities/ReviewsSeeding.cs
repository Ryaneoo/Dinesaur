using Dinesaur.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Dinesaur.Configurations.Entities
{
    public class ReviewsSeeding : IEntityTypeConfiguration<Review>
    {

        public void Configure(EntityTypeBuilder<Review> builder)
        {
            builder.HasData(
                new Review
                {
                    ReviewTitle = "Bad",
                    ReviewID = 1,
                    Location = "Orchard",
                    Date = DateTime.Now,
                    Rating = 2.5,
                    Description = "Bad",
                    RestaurantID = 1,
                    CustomerID = 1
                });
        }
    }
}
