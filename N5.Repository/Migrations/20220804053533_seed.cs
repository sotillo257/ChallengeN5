using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace N5.Repository.Migrations
{
    public partial class seed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "PermissionTypes",
                columns: new[] { "Id", "Description" },
                values: new object[] { 1, "High" });

            migrationBuilder.InsertData(
                table: "PermissionTypes",
                columns: new[] { "Id", "Description" },
                values: new object[] { 2, "Medium" });

            migrationBuilder.InsertData(
                table: "PermissionTypes",
                columns: new[] { "Id", "Description" },
                values: new object[] { 3, "Low" });

            migrationBuilder.InsertData(
                table: "Permissions",
                columns: new[] { "Id", "ApellidoEmpleado", "FechaPermiso", "NombreEmpleado", "PermissionTypeID" },
                values: new object[] { 1, "Sotillo", new DateTime(2022, 8, 4, 1, 35, 33, 69, DateTimeKind.Local).AddTicks(4628), "Jesus", 1 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "PermissionTypes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "PermissionTypes",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "PermissionTypes",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
