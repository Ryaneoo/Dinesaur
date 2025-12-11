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
                }
            );
        }
    }
}

