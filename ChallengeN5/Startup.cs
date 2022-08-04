
using Microsoft.EntityFrameworkCore;
using N5.Core.Contracts;
using N5.Core.Implementations;
using N5.Repository;

namespace ChallengeN5
{
    public class Startup
    {
        public IConfiguration Configuration { get; }
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        public void ConfigureServices(IServiceCollection services)
        {

            services.AddControllers();
            services.AddDbConfig<DefaultContext>(Configuration, "Default", "N5.Repository");

            #region Dependency Injection Definition

            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<IPermissionServices, PermissionServices>();
            services.AddScoped<IPermissionTypeServices, PermissionTypeServices>();
            #endregion
            services.AddSwaggerGen();
            services.AddEndpointsApiExplorer();


        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {

            // Configure the HTTP request pipeline.
            //if (app.Environment.IsDevelopment())
            //{
            app.UseSwagger();
                app.UseSwaggerUI();
            //}
            app.UseCors(
              options => options.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod()
           );

            app.UseHttpsRedirection();

            app.UseAuthorization();
            app.UseRouting();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
