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
        public int StaffID { get; set; } 
    }
}
