namespace Task1_ASP.NET_Core_API.Entities
{
    public class Employee : BaseSettingsEntity
    {
        public string? Department { get; set; }
        public List<CustomerEmployee>? CustomerEmployees { get; set; }
        public List<ProspectEmpolyee>? ProspectEmpolyees { get; set; }

    }
}
