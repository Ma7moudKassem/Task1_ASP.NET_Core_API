namespace Task1_ASP.NET_Core_API.Services.EmpolyeeServices
{
    public class EmpolyeeServices : BaseServices<Employee>, IEmpolyeeServices
    {
        public EmpolyeeServices(ApplicationDbContext context) : base(context) { }
    }
}
