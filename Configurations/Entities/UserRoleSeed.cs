using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Dinesaur.Configurations.Entities
{
    public class UserRoleSeed : IEntityTypeConfiguration<IdentityUserRole<string>>
    {
        public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
        {
            builder.HasData(
                new IdentityUserRole<string>
                {
                    UserId = "1", // Admin User
                    RoleId = "1"  // Administrator Role
                },
                new IdentityUserRole<string>
                {
                    UserId = "2", // Regular User
                    RoleId = "2"  // User Role
                },
                new IdentityUserRole<string>
                {
                    UserId = "3", // Restaurant Staff User
                    RoleId = "3"  // RestaurantStaff Role
                },
                new IdentityUserRole<string>
                {
                    UserId = "4", // Restaurant Staff User
                    RoleId = "3"  // RestaurantStaff Role
                },
                new IdentityUserRole<string>
                {
                    UserId = "5", // Restaurant Staff User
                    RoleId = "3"  // RestaurantStaff Role
                },
                new IdentityUserRole<string>
                {
                    UserId = "6", // Restaurant Staff User
                    RoleId = "3"  // RestaurantStaff Role
                },
                new IdentityUserRole<string>
                {
                    UserId = "7", // Restaurant Staff User
                    RoleId = "3"  // RestaurantStaff Role
                },

                new IdentityUserRole<string>
                {
                    UserId = "8", 
                    RoleId = "2"  
                },

                new IdentityUserRole<string>
                {
                    UserId = "9", 
                    RoleId = "2"  
                },

                new IdentityUserRole<string>
                {
                    UserId = "10", 
                    RoleId = "2"  
                },

                new IdentityUserRole<string>
                {
                    UserId = "11", 
                    RoleId = "3"  
                }
            );
        }
    }
}

