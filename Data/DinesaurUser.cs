using Microsoft.AspNetCore.Identity;

namespace Dinesaur.Data
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class DinesaurUser : IdentityUser
    {
        public string? Name { get; set; }
        

        public int? Contact { get; set; }

        public DateTime CreatedAtUtc { get; set; } = DateTime.UtcNow;


        public DateTime? LastLoginAtUtc { get; set; }

    }
}
