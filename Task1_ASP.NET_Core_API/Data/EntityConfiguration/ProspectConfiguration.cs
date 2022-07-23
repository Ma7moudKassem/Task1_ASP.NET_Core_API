using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Task1_ASP.NET_Core_API.Data.EntityConfiguration
{
    public class ProspectConfiguration : BaseSettingsConfiguration<Prospect> , IEntityTypeConfiguration<Prospect>
    {
        public virtual new void Configure(EntityTypeBuilder<Prospect> builder)
        {
            base.Configure(builder);
            builder.ToTable("ProspectTable");
            //builder.HasMany(e => e.Employees).WithMany(e => e.Prospects).UsingEntity<ProspectEmpolyee>(
            //            e => e
            //               .HasOne(e => e.Employee)
            //               .WithMany(e => e.ProspectEmpolyees)
            //               .HasForeignKey(e => e.EmployeeId),
            //            e => e.HasOne(e => e.Prospect)
            //                .WithMany(e => e.ProspectEmpolyees)
            //                .HasForeignKey(e => e.ProspectId),
            //            e => e.HasKey(e => new { e.ProspectId, e.EmployeeId })
            //           );


        }
    }
}
