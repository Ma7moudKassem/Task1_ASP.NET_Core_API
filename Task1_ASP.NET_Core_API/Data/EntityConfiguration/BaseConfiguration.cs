using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Task1_ASP.NET_Core_API.Data.EntityConfiguration
{
    public class BaseConfiguration<TEntity> : IEntityTypeConfiguration<TEntity> where TEntity : BaseEntity
    {
        public virtual void Configure(EntityTypeBuilder<TEntity> builder)
        {
            builder.HasKey(e => e.Id);
            builder.Property(e => e.Id).IsRequired();
            builder.HasIndex(e => e.Id).IsUnique();
        }
    }
}
