using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using N5.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N5.Repository
{
    public class PermissionConfiguration<T> : IEntityTypeConfiguration<T>
        where T : Permission
    {
        public  void Configure(EntityTypeBuilder<T> builder)
        {            
            builder.ToTable("Permissions");
            builder.HasKey(p => p.Id);
            builder.Property(x => x.NombreEmpleado).IsRequired();
            builder.Property(x => x.ApellidoEmpleado).IsRequired();
            builder.Property(x => x.FechaPermiso).IsRequired();

            builder.HasOne(x => x.PermissionType)
                .WithMany()
                .HasForeignKey(x => x.PermissionTypeID);

        }
    }
}
