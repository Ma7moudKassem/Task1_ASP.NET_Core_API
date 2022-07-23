using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Task1_ASP.NET_Core_API.Data.EntityConfiguration
{
    public class BaseSettingsConfiguration<TEntity> : BaseEntity , IEntityTypeConfiguration<TEntity> where TEntity : BaseSettingsEntity
    { 
        public void Configure(EntityTypeBuilder<TEntity> builder)
        {
            builder.Property(e => e.Name).IsRequired();
            builder.Property(e => e.Name).HasMaxLength(100);
            builder.Property(e => e.AddressStreet).IsRequired();
            builder.Property(e => e.AddressStreet).HasMaxLength(250);
            builder.Property(e => e.AddressNumber).IsRequired();
            builder.Property(e => e.PhoneNumber).IsRequired();
        }
    }
}
