namespace Task1_ASP.NET_Core_API.Services
{
    public class ProspectServices : BaseServices<Prospect>, IProspectServices
    {
        public ProspectServices(ApplicationDbContext context) : base(context) { }
    }
}
