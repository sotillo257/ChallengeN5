using Microsoft.EntityFrameworkCore;
using N5.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N5.Repository
{
    public  class DataBase
    {
        public static void Seed(ModelBuilder builder)
        {
            SeedPermissionType(builder);
            SeedPermission(builder);
        }

        private static void SeedPermissionType(ModelBuilder builder)
        {
            builder.Entity<PermissionType>().HasData(new List<PermissionType>()
            {
                new PermissionType() {Id = 1, Description = "High" },
                new PermissionType() {Id = 2, Description = "Medium" },
                new PermissionType() {Id = 3, Description = "Low" }
            });
        }

        private static void SeedPermission(ModelBuilder builder)
        {
            builder.Entity<Permission>().HasData(new List<Permission>()
            {
                new Permission() {Id = 1, NombreEmpleado = "Jesus", ApellidoEmpleado="Sotillo",FechaPermiso= DateTime.Now,PermissionTypeID=1 }
            });
        }
    }
}
