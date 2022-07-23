namespace Task1_ASP.NET_Core_API.Entities
{
    public class Customer : BaseSettingsEntity 
    {
        public int ProspectId { get; set; }
        public Prospect? Prospect { get; set; }
        //public ICollection<CustomerEmployee> CustomerEmployees { get; set; }
    }
}
