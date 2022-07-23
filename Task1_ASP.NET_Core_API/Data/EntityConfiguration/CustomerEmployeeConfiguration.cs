using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Task1_ASP.NET_Core_API.Data.EntityConfiguration
{
    public class CustomerEmployeeConfiguration :  IEntityTypeConfiguration<CustomerEmployee>
    {
        public void Configure(EntityTypeBuilder<CustomerEmployee> builder)
        {
            builder.ToTable("CustomerEmployeeTable");
            builder.HasKey(e =>new { e.CustomerId , e.EmployeeId });
            builder.HasOne(e=>e.Employee).WithMany(e=>e.CustomerEmployees)
                .HasForeignKey(e=>e.EmployeeId).OnDelete(DeleteBehavior.Cascade);            
            builder.HasOne(e=>e.Customer).WithMany()
                .HasForeignKey(e=>e.EmployeeId)
                .OnDelete(DeleteBehavior.Cascade);

        }
    }
} 
