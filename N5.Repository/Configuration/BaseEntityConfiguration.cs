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
    public abstract class BaseEntityConfiguration<T> : IEntityTypeConfiguration<T>
        where T : Entity<int>
    {
        public virtual void Configure(EntityTypeBuilder<T> builder)
        {
            // Set key for entity
            builder.HasKey(p => p.Id);
        }
    }
}
