namespace Task1_ASP.NET_Core_API.Entities
{
    public class CustomerEmployee : BaseEntity
    {
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }        
        public int EmployeeId { get; set; }
        public Employee? Employee { get; set; }
        public DateTime DateTime { get; set; }
    }
}
