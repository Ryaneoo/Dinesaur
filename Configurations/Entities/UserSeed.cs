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
                
                Contact = 91234568,
                UserName = "user@localhost.com",
                NormalizedUserName = "USER@LOCALHOST.COM",
                PasswordHash = hasher.HashPassword(null, "P@ssword1"),
                EmailConfirmed = true // Set to true, otherwise you won't be able to login
            },
            new DinesaurUser
            {
                Id = "3",
                Email = "restaurantstaff@localhost.com",
                NormalizedEmail = "RESTAURANTSTAFF@LOCALHOST.COM",
                Name = "RestaurantStaff",
                
                Contact = 91234560,
                UserName = "restaurantstaff@localhost.com",
                NormalizedUserName = "RESTAURANTSTAFF@LOCALHOST.COM",
                PasswordHash = hasher.HashPassword(null, "P@ssword1"),
                EmailConfirmed = true // Set to true, otherwise you won't be able to login
            }
            );
        }
    }
}
