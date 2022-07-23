using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Task1_ASP.NET_Core_API.Data.EntityConfiguration
{
    public class ProspectEmpolyeeConfiguration : IEntityTypeConfiguration<ProspectEmpolyee>
    {
        public void Configure(EntityTypeBuilder<ProspectEmpolyee> builder)
        {
            builder.ToTable("ProspectEmpolyeeTable");
            builder.HasKey(e => new { e.ProspectId, e.EmployeeId });
            builder.HasOne(e => e.Prospect).WithMany()
                    .HasForeignKey(e => e.ProspectId).OnDelete(DeleteBehavior.Cascade);
            builder.HasOne(e => e.Employee).WithMany(e=>e.ProspectEmpolyees)
                .HasForeignKey(e => e.EmployeeId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
