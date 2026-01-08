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
                    Date = new DateTime(2026, 1, 9, 14, 0, 0),
                    Time = new DateTime(2026, 1, 9, 18, 0, 0),
                    CustomerID = "2",
                    Pax = 4,
                    RestaurantID = 1,
                    Status = Reservation.ReservationStatus.Confirmed,
                    Remarks = "N/A"
                },
                new Reservation
                {
                    ReservationID = 2,
                    Date = new DateTime(2026, 1, 10, 12, 0, 0),
                    Time = new DateTime(2026, 1, 10, 14, 0, 0),
                    CustomerID = "2",
                    Pax = 2,
                    RestaurantID = 1,
                    Status = Reservation.ReservationStatus.Pending,
                    Remarks = "N/A"
                },
                new Reservation
                {
                    ReservationID = 3,
                    Date = new DateTime(2026, 1, 13, 13, 0, 0),
                    Time = new DateTime(2026, 1, 13, 15, 0, 0),
                    CustomerID = "2",
                    Pax = 3,
                    RestaurantID = 1,
                    Status = Reservation.ReservationStatus.Completed,
                    Remarks = "N/A"
                },
                new Reservation
                {
                    ReservationID = 4,
                    Date = new DateTime(2026, 1, 15, 18, 0, 0),
                    Time = new DateTime(2026, 1, 15, 20, 0, 0),
                    CustomerID = "2",
                    Pax = 4,
                    RestaurantID = 1,
                    Status = Reservation.ReservationStatus.Pending,
                    Remarks = "N/A"
                },
                new Reservation
                {
                    ReservationID = 5,
                    Date = new DateTime(2026, 1, 18, 12, 0, 0),
                    Time = new DateTime(2026, 1, 18, 14, 0, 0),
                    CustomerID = "2",
                    Pax = 2,
                    RestaurantID = 1,
                    Status = Reservation.ReservationStatus.Confirmed,
                    Remarks = "N/A"
                },

                // Past Completed Reservations
                new Reservation
                {
                    ReservationID = 6,
                    Date = new DateTime(2025, 12, 20, 13, 0, 0),
                    Time = new DateTime(2025, 12, 20, 15, 0, 0),
                    CustomerID = "2",
                    Pax = 2,
                    RestaurantID = 1,
                    Status = Reservation.ReservationStatus.Completed,
                    Remarks = "N/A"
                },
                new Reservation
                {
                    ReservationID = 7,
                    Date = new DateTime(2025, 12, 22, 18, 0, 0),
                    Time = new DateTime(2025, 12, 22, 20, 0, 0),
                    CustomerID = "2",
                    Pax = 4,
                    RestaurantID = 1,
                    Status = Reservation.ReservationStatus.Completed,
                    Remarks = "N/A"
                },
                new Reservation
                {
                    ReservationID = 8,
                    Date = new DateTime(2025, 12, 25, 12, 0, 0),
                    Time = new DateTime(2025, 12, 25, 14, 0, 0),
                    CustomerID = "2",
                    Pax = 3,
                    RestaurantID = 1,
                    Status = Reservation.ReservationStatus.Completed,
                    Remarks = "N/A"
                }
            );
        }
    }
}


        
