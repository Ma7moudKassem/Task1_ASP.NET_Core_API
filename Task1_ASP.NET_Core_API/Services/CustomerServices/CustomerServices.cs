namespace Task1_ASP.NET_Core_API.Services
{
    public class CustomerServices : BaseServices<Customer>, ICustomerServices
    {
        public CustomerServices(ApplicationDbContext context) : base(context) { }
    }
}
