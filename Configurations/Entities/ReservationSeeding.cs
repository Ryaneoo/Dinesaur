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
                    CustomerID = "2",
                    RestaurantID = 1,
                    Status = Reservation.ReservationStatus.Confirmed

                },
                new Reservation
                {
                    ReservationID = 2,
                    EndDate = DateTime.Now.AddHours(2),
                    Remarks = "Null",
                    CustomerID = "2",
                    RestaurantID = 1,
                    Status = Reservation.ReservationStatus.Completed
                },
                new Reservation
                {
                    ReservationID = 3,
                    EndDate = DateTime.Now.AddHours(2),
                    Remarks = "Null",
                    CustomerID = "2",
                    RestaurantID = 1,
                    Status = Reservation.ReservationStatus.Pending
                },
                new Reservation
                {
                    ReservationID = 4,
                    EndDate = DateTime.Now.AddHours(2),
                    Remarks = "Null",
                    CustomerID = "2",
                    RestaurantID = 1,
                    Status = Reservation.ReservationStatus.Completed
                }
            );
        }
    }
}
