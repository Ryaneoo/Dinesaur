namespace Dinesaur.Domain
{
    public class DinesaurUserModel:BaseDomainModel
    {
        public int Id { get; set; }
        public string? DinesaurUserID { get; set; }
        

        public string? DinesaurUserName { get; set; }
    }
}
