using Dinesaur.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Dinesaur.Configurations.Entities
{
    public class PreorderSeeding : IEntityTypeConfiguration<PreOrder>
    {
        public void Configure(EntityTypeBuilder<PreOrder> builder)
        {
            builder.HasData(
                new PreOrder
                {
                    PreOrderID = 1,
                    Cost = 3.50,
                    MenuID = 1,
                    ReservationID = 1,
                    Remarks = "Please remove the onions"
                },
                new PreOrder
                {
                    PreOrderID = 2,
                    Cost = 4.00,
                    MenuID = 2,
                    ReservationID = 2,
                    Remarks = "Please remove all vegetables"
                });
        }
    }
}

