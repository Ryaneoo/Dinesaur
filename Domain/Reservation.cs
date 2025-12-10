namespace Dinesaur.Domain
{
    public class Reservation
    {
        public int ReservationID { get; set; }

        public DateTime Date { get; set; }
        public string? Location { get; set; }

        public string? Remarks { get; set; }

        public int CustomerID { get; set; }

        public int RestaurantID { get; set; }

        public int StaffID { get; set; } 
    }
}
