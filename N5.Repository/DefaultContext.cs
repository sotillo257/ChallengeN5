using Microsoft.EntityFrameworkCore;
using N5.Core.Models;

namespace N5.Repository
{
    public class DefaultContext : DbContext
    {
        public DefaultContext(DbContextOptions<DefaultContext> options) : base(options)
        {

        }
        public override int SaveChanges(bool acceptAllChangesOnSuccess)
        {
            return base.SaveChanges(acceptAllChangesOnSuccess);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            ConfigureMapping(modelBuilder);
        }

        private static void ConfigureMapping(ModelBuilder modelBuilder)
        {
            modelBuilder
                .ApplyConfiguration(new PermissionConfiguration<Permission>())
                .ApplyConfiguration(new PermissionTypeConfiguration<PermissionType>());
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
         
        }
    }
}