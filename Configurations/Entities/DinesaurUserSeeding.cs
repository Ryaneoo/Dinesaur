using Dinesaur.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Dinesaur.Configurations.Entities
{
    public class DinesaurUserSeeding : IEntityTypeConfiguration<DinesaurUserModel>
    {
        public void Configure(EntityTypeBuilder<DinesaurUserModel> builder)
        {
            builder.HasData(
                new DinesaurUserModel
                {   
                    Id = 1,
                    DinesaurUserID = "2",
                    DinesaurUserName = "User",
                    Contact = 91234568,
                    Email = "user@localhost.com"
                }
                );
        }
    }
}
