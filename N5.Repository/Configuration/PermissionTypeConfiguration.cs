using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using N5.Core.Models;

namespace N5.Repository
{
    public class PermissionTypeConfiguration<T> : IEntityTypeConfiguration<T>
        where T : PermissionType
    {
        public void Configure(EntityTypeBuilder<T> builder)
        {
            builder.ToTable("PermissionTypes");
            builder.HasKey(p => p.Id);
            builder.Property(x => x.Description).IsRequired();
        }
    }
}
