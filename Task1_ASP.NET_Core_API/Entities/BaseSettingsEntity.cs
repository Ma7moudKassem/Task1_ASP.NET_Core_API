namespace Task1_ASP.NET_Core_API.Entities
{
    public class BaseSettingsEntity : BaseEntity
    {
        public string? Name { get; set; }
        public int AddressNumber { get; set; }
        public string? AddressStreet { get; set; }
        public int PhoneNumber { get; set; }
    }
}
