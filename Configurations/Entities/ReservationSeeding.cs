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
                    Date = new DateTime(2026, 2, 10, 0, 0, 0),
                    Time = new TimeOnly(12, 30),
                    CustomerID = "8",
                    Pax = 4,
                    RestaurantID = 1,
                    Status = Reservation.ReservationStatus.Pending,
                    Remarks = "N/A"
                },

                new Reservation
                {
                    ReservationID = 2,
                    Date = new DateTime(2026, 1, 15, 0, 0, 0),
                    Time = new TimeOnly(18, 30),
                    CustomerID = "8",
                    Pax = 2,
                    RestaurantID = 2,
                    Status = Reservation.ReservationStatus.Completed,
                    Remarks = "N/A"
                },

                new Reservation
                {
                    ReservationID = 3,
                    Date = new DateTime(2026, 3, 15, 0, 0, 0),
                    Time = new TimeOnly(13, 30),
                    CustomerID = "8",
                    Pax = 10,
                    RestaurantID = 1,
                    Status = Reservation.ReservationStatus.Cancelled,
                    Remarks = "1 Baby Chair"
                },

                new Reservation
                {
                    ReservationID = 4,
                    Date = new DateTime(2026, 3, 1, 0, 0, 0),
                    Time = new TimeOnly(14, 30),
                    CustomerID = "9",
                    Pax = 2,
                    RestaurantID = 3,
                    Status = Reservation.ReservationStatus.Pending,
                    Remarks = "N/A"
                },

                new Reservation
                {
                    ReservationID = 5,
                    Date = new DateTime(2026, 1, 1, 0, 0, 0),
                    Time = new TimeOnly(19, 30),
                    CustomerID = "9",
                    Pax = 3,
                    RestaurantID = 2,
                    Status = Reservation.ReservationStatus.Completed,
                    Remarks = "N/A"
                },

                new Reservation
                {
                    ReservationID = 6,
                    Date = new DateTime(2026, 2, 5, 0, 0, 0),
                    Time = new TimeOnly(14, 30),
                    CustomerID = "9",
                    Pax = 5,
                    RestaurantID = 3,
                    Status = Reservation.ReservationStatus.Confirmed,
                    Remarks = "N/A"
                }
            );
        }
    }
}


        
