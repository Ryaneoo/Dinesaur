using Dinesaur.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Dinesaur.Configurations.Entities
{
    public class PreOrderItemSeeding : IEntityTypeConfiguration<PreOrderItem>
    {
        public void Configure(EntityTypeBuilder<PreOrderItem> builder)
        {
            builder.HasData(
                new PreOrderItem
                {
                    PreorderItemID = 1,
                    Quantity = 1,
                    PreOrderID = 1,
                    FoodID = 1
                },
                new PreOrderItem
                {
                    PreorderItemID = 2,
                    Quantity = 2,
                    PreOrderID = 1,
                    FoodID = 1
                }
            );
        }
    }

}