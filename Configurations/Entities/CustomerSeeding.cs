using Dinesaur.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Dinesaur.Configurations.Entities
{
    public class CustomerSeeding : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.HasData(
                new Customer
                {
                    CustomerID = 1,
                    CustomerName = "Ryan",
                    Contact = 99999999,
                    Email = "banana@gmail.com"
                },
                new Customer
                {
                    CustomerID = 2,
                    CustomerName = "Oliver",
                    Contact = 123456789,
                    Email = "Oliver23@gmail.com"
                }
                );
        }
    }
}
