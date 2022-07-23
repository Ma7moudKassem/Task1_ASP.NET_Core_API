using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Task1_ASP.NET_Core_API.Data.EntityConfiguration
{
    public class EmployeeConfiguration : BaseSettingsConfiguration<Employee>, IEntityTypeConfiguration<Employee>
    {
        public virtual new void Configure(EntityTypeBuilder<Employee> builder)
        {
            base.Configure(builder);
            builder.ToTable("EmpolyeeTable");
            builder.Property(e => e.Department).HasMaxLength(50);
            builder.HasMany(e => e.ProspectEmpolyees)
                .WithOne(e => e.Employee).HasForeignKey(e => e.EmployeeId).OnDelete(DeleteBehavior.Cascade);
            builder.HasMany(e => e.CustomerEmployees).WithOne(e => e.Employee).HasForeignKey(e => e.CustomerId).OnDelete(DeleteBehavior.Cascade);


        }
    }
}
