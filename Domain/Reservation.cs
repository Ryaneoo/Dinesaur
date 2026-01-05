namespace Dinesaur.Domain
{
    public class Reservation
    {
        public int ReservationID { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int Pax { get; set; }
        public string? Remarks { get; set; }
        public string CustomerID { get; set; }
        public int RestaurantID { get; set; }
        public enum ReservationStatus
        {
            Pending = 0,
            Confirmed = 1,
            Completed = 2,
            Rejected = 3,
        }
        public ReservationStatus Status{ get; set; } = ReservationStatus.Pending;
    }
}
