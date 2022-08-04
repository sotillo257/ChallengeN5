using Microsoft.EntityFrameworkCore;

namespace ChallengeN5
{
    public static class MiddlewareConfigurations
    {

        public static void AddDbConfig<T>(this IServiceCollection services, IConfiguration config, string connectionStringName, string migrationNamespace) where T : DbContext
        {
            if (!string.IsNullOrEmpty(migrationNamespace))
            {
                services.AddDbContext<T>(options => options.UseSqlServer(config.GetConnectionString(connectionStringName), x => x.MigrationsAssembly(migrationNamespace)));
            }
            else
            {
                services.AddDbContext<T>(options => options.UseSqlServer(config.GetConnectionString(connectionStringName)));
            }
        }
    }
}
