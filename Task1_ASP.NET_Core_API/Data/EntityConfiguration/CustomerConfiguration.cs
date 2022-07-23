using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Task1_ASP.NET_Core_API.Data.EntityConfiguration
{
    public class CustomerConfiguration : BaseSettingsConfiguration<Customer>, IEntityTypeConfiguration<Customer>
    {
        public virtual new void Configure(EntityTypeBuilder<Customer> builder)
        {
            base.Configure(builder);
            builder.ToTable("CustomerTable");
            //builder.HasMany(e => e.Employees).WithMany(e => e.Customers).UsingEntity<CustomerEmployee>(
            //            e => e
            //               .HasOne(e => e.Employee)
            //               .WithMany(e => e.CustomerEmployees)
            //               .HasForeignKey(e => e.EmployeeId),
            //            e => e.HasOne(e => e.Customer)
            //                .WithMany(e => e.CustomerEmployees)
            //                .HasForeignKey(e => e.CustomerId),
            //            e => e.HasKey(e => new { e.CustomerId, e.EmployeeId })

            //           );
        }
    }
}
