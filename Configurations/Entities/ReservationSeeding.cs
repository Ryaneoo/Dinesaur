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
                    Date = DateTime.Now,
                    Location = "Orchard",
                    Remarks = "Null",
                    CustomerID = 1,
                    RestaurantID = 1,
                    StaffID = 1

                },
                new Reservation
                {
                    ReservationID = 2,
                    Date = DateTime.Now,
                    Location = "Novena",
                    Remarks = "Null",
                    CustomerID = 2,
                    RestaurantID = 2,
                    StaffID = 2
                }
            );
        }
    }
}
