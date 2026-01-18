using Dinesaur.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Dinesaur.Configurations.Entities
{
    public class UserSeed : IEntityTypeConfiguration<DinesaurUser>
    {
        public void Configure(EntityTypeBuilder<DinesaurUser> builder)
        {
            var hasher = new PasswordHasher<DinesaurUser>();
            builder.HasData(
            new DinesaurUser
            {
                Id = "1",
                Email = "admin@localhost.com",
                NormalizedEmail = "ADMIN@LOCALHOST.COM",
                Name = "Admin",
                
                Contact = 91234567,
                UserName = "admin@localhost.com",
                NormalizedUserName = "ADMIN@LOCALHOST.COM",
                PasswordHash = hasher.HashPassword(null, "P@ssword1"),
                EmailConfirmed = true // Set to true, otherwise you won't be able to login
            },
            new DinesaurUser
            {
                Id = "2",
                Email = "user@localhost.com",
                NormalizedEmail = "USER@LOCALHOST.COM",
                Name = "User",
                
                Contact = 97826235,
                UserName = "user@localhost.com",
                NormalizedUserName = "USER@LOCALHOST.COM",
                PasswordHash = hasher.HashPassword(null, "P@ssword1"),
                EmailConfirmed = true // Set to true, otherwise you won't be able to login
            },
            new DinesaurUser
            {
                Id = "3",
                Email = "Tomahawk@gmail.com",
                NormalizedEmail = "TOMAHAWK@GMAIL.COM",
                Name = "Tomahawk Admin",
                
                Contact = 82613992,
                UserName = "Tomahawk@gmail.com",
                NormalizedUserName = "TOMAHAWK@GMAIL.COM",
                PasswordHash = hasher.HashPassword(null, "P@ssword1"),
                EmailConfirmed = true // Set to true, otherwise you won't be able to login
            },
            new DinesaurUser
            {
                Id = "4",
                Email = "ButcherBlock@gmail.com",
                NormalizedEmail = "BUTCHERBLOCK@GMAIL.COM",
                Name = "ButcherAdmin",

                Contact = 82613992,
                UserName = "ButcherBlock@gmail.com",
                NormalizedUserName = "BUTCHERBLOCK@GMAIL.COM",
                PasswordHash = hasher.HashPassword(null, "P@ssword1"),
                EmailConfirmed = true // Set to true, otherwise you won't be able to login
            },
            new DinesaurUser
            {
                Id = "5",
                Email = "labula@gmail.com",
                NormalizedEmail = "LABULA@GMAIL.COM",
                Name = "LabulaAdmin",

                Contact = 88706606,
                UserName = "labula@gmail.com",
                NormalizedUserName = "LABULA@GMAIL.COM",
                PasswordHash = hasher.HashPassword(null, "P@ssword1"),
                EmailConfirmed = true // Set to true, otherwise you won't be able to login
            },
            new DinesaurUser
            {
                Id = "6",
                Email = "chefhats@gmail.com",
                NormalizedEmail = "CHEFHATS@GMAIL.COM",
                Name = "ChefHatsAdmin",

                Contact = 94799101,
                UserName = "chefhats@gmail.com",
                NormalizedUserName = "CHEFHATS@GMAIL.COM",
                PasswordHash = hasher.HashPassword(null, "P@ssword1"),
                EmailConfirmed = true // Set to true, otherwise you won't be able to login
            },
            new DinesaurUser
            {
                Id = "7",
                Email = "tdp@gmail.com",
                NormalizedEmail = "TDP@GMAIL.COM",
                Name = "TDPAdmin",

                Contact = 91234560,
                UserName = "tdp@gmail.com",
                NormalizedUserName = "TDP@GMAIL.COM",
                PasswordHash = hasher.HashPassword(null, "P@ssword1"),
                EmailConfirmed = true // Set to true, otherwise you won't be able to login
            },
            new DinesaurUser
            {
                Id = "8",
                Email = "oliverchay@gmail.com",
                NormalizedEmail = "OLIVERCHAY@GMAIL.COM",
                Name = "Oliver",

                Contact = 96409718,
                UserName = "oliverchay@gmailcom",
                NormalizedUserName = "OLIVERCHAY@GMAIL.COM",
                PasswordHash = hasher.HashPassword(null, "P@ssword1"),
                EmailConfirmed = true // Set to true, otherwise you won't be able to login
            },
            new DinesaurUser
            {
                Id = "9",
                Email = "ryanneo@gmail.com",
                NormalizedEmail = "RYANNEO@GMAIL.COM",
                Name = "Ryan",

                Contact = 93278292,
                UserName = "ryanneo@gmail.com",
                NormalizedUserName = "RYANNEO@GMAIL.COM",
                PasswordHash = hasher.HashPassword(null, "P@ssword1"),
                EmailConfirmed = true // Set to true, otherwise you won't be able to login
            },

            new DinesaurUser
            {
                Id = "10",
                Email = "dustindomingo@gmail.com",
                NormalizedEmail = "DUSTINDOMINGO@GMAIL.COM",
                Name = "Dustin",

                Contact = 97629623,
                UserName = "dustindomingo@gmail.com",
                NormalizedUserName = "DUSTINDOMINGO@GMAIL.COM",
                PasswordHash = hasher.HashPassword(null, "P@ssword1"),
                EmailConfirmed = true // Set to true, otherwise you won't be able to login
            },

            new DinesaurUser
            {
                Id = "11",
                Email = "restaurantstaff@localhost.com",
                NormalizedEmail = "RESTAURANTSTAFF@localhost.COM",
                Name = "RestaurantStaff",

                Contact = 97237323,
                UserName = "restaurantstaff@localhost.com",
                NormalizedUserName = "RESTAURANTSTAFF@localhost.COM",
                PasswordHash = hasher.HashPassword(null, "P@ssword1"),
                EmailConfirmed = true // Set to true, otherwise you won't be able to login
            }
            );
        }
    }
}
