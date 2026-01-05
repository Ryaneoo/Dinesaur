using Dinesaur.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Dinesaur.Configurations.Entities
{
    public class ReservationSeeding : IEntityTypeConfiguration<Reservation>
    {
        public void Configure(EntityTypeBuilder<Reservation> builder)
        {
            builder.HasData(

                new Reservation
                {
                    ReservationID = 1,
                    StartDate = DateTime.Now,
                    EndDate = DateTime.Now.AddHours(2),
                    CustomerID = "1",
                    RestaurantID = 1,
                    Status = "Pending"

                },
                new Reservation
                {
                    ReservationID = 2,
                    EndDate = DateTime.Now.AddHours(2),
                    Remarks = "Null",
                    CustomerID = "1",
                    RestaurantID = 2,
                    Status = "Completed"
                }
            );
        }
    }
}
