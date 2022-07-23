namespace Task1_ASP.NET_Core_API.Entities
{
    public class ProspectEmpolyee : BaseEntity
    {
        public int ProspectId { get; set; }
        public Prospect? Prospect { get; set; }
        public int EmployeeId { get; set; }
        public Employee? Employee { get; set; }
    }
}
