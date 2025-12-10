namespace Dinesaur.Domain
{
    public class RestaurantStaff:BaseDomainModel
    {
        public int StaffID { get; set; }

        public string? StaffName { get; set; }

        public int RestaurantID { get; set; }
    }
}
