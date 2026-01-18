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
                    RestaurantName = "Tomahawk Contemporary Steakhouse",
                    Location = "273, #01-06 Thomson Rd, Novena Gardens, Singapore 307644",
                    Category = "Western",
                    AdminID = 1,
                    OpeningHours = new TimeOnly(12, 0),
                    ClosingHours = new TimeOnly(22, 0),
                    RestaurantOwnerID = "3",
                    Logo = ["/Images/Tomahawk.jpeg"],
                    
                    Contact = 82613992,
                    Email = "tomahawk@gmail.com",
                    Status = Restaurant.ApprovalStatus.Approved
                },
                new Restaurant
                {
                    RestaurantID = 2,
                    RestaurantName = "Butcher's Block",
                    Location = "328 N Bridge Rd, #02-02 RAFFLES ARCADE, Singapore 188719",
                    Category = "Fine Dining",
                    AdminID = 1,
                    OpeningHours = new TimeOnly(12, 0),
                    ClosingHours = new TimeOnly(21, 30),

                    RestaurantOwnerID = "4",
                    Logo = ["/Images/Butcher.jpg"],

                    Contact = 64121816,
                    Email = "ButcherBlock@gmail.com",
                    Status = Restaurant.ApprovalStatus.Approved
                },

                new Restaurant
                {
                    RestaurantID = 3,
                    RestaurantName = "辣不辣 Labula Mala Sichuan Restaurant",
                    Location = "681 Punggol Dr., #01-07, Singapore 820681",
                    Category = "HotPot",
                    AdminID = 1,
                    OpeningHours = new TimeOnly(10, 30),
                    ClosingHours = new TimeOnly(22, 30),

                    RestaurantOwnerID = "5",
                    Logo = ["/Images/LABULA.jpg"],

                    Contact = 88706606,
                    Email = "labula@gmail.com",
                    Status = Restaurant.ApprovalStatus.Approved
                },
                new Restaurant
                {
                    RestaurantID = 4,
                    RestaurantName = "Chef's Hats",
                    Location = "21 Hougang St 51, #01-01A Hougang GREEN Shopping Mall, Singapore 538719",
                    Category = "Western",
                    AdminID = 1,
                    OpeningHours = new TimeOnly(10, 00),
                    ClosingHours = new TimeOnly(22, 00),

                    RestaurantOwnerID = "6",
                    Logo = ["/Images/Chef.jpg"],

                    Contact = 94799101,
                    Email = "chefhats@gmail.com",
                    Status = Restaurant.ApprovalStatus.Pending
                },
                new Restaurant
                {
                    RestaurantID = 5,
                    RestaurantName = "The Dessert Party",
                    Location = "406 Tampines Street 41, #01-23 Sun Plaza Green, Singapore 520406",
                    Category = "Dessert",
                    AdminID = 1,
                    OpeningHours = new TimeOnly(11, 30),
                    ClosingHours = new TimeOnly(17, 30),

                    RestaurantOwnerID = "7",
                    Logo = ["/Images/tdp.jpeg"],

                    Contact = 94350556,
                    Email = "tdp@gmail.com",
                    Status = Restaurant.ApprovalStatus.Rejected
                });
        }
    }
}
