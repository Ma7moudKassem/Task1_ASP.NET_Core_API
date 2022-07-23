namespace Task1_ASP.NET_Core_API.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CustomerConfiguration())
                        .ApplyConfiguration(new EmployeeConfiguration())
                        .ApplyConfiguration(new CustomerEmployeeConfiguration())
                        .ApplyConfiguration(new ProspectConfiguration())
                        .ApplyConfiguration(new ProspectEmpolyeeConfiguration());
        }
    }
}
