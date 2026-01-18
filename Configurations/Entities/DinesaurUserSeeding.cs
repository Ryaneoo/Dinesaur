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
                    Contact = 97826235,
                    Email = "user@localhost.com"
                },

                new DinesaurUserModel
                {
                    Id = 2,
                    DinesaurUserID = "8",
                    DinesaurUserName = "Oliver",
                    Contact = 96409718,
                    Email = "user@localhost.com"
                },

                new DinesaurUserModel
                {
                    Id = 3,
                    DinesaurUserID = "9",
                    DinesaurUserName = "Ryan",
                    Contact = 93278292,
                    Email = "user@localhost.com"
                },
                new DinesaurUserModel
                {
                    Id = 4,
                    DinesaurUserID = "10",
                    DinesaurUserName = "Dustin",
                    Contact = 97629623,
                    Email = "dustindomingo@gmail.com"
                }
                );
        }
    }
}
