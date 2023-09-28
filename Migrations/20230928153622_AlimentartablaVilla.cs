using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MagicVillaAPI.Migrations
{
    /// <inheritdoc />
    public partial class AlimentartablaVilla : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Villas",
                columns: new[] { "Id", "Amenidad", "Detalle", "FechaActualizacion", "FechaCreacion", "ImagenUrl", "MetrosCuadrados", "Nombre", "Ocupantes", "Tarifa" },
                values: new object[,]
                {
                    { 1, "", "Detalle de la villa", new DateTime(2023, 9, 28, 10, 36, 22, 214, DateTimeKind.Local).AddTicks(2527), new DateTime(2023, 9, 28, 10, 36, 22, 214, DateTimeKind.Local).AddTicks(2518), "", 50, "Villa Real", 5, 200.0 },
                    { 2, "", "Detalle de la villa 2", new DateTime(2023, 9, 28, 10, 36, 22, 214, DateTimeKind.Local).AddTicks(2559), new DateTime(2023, 9, 28, 10, 36, 22, 214, DateTimeKind.Local).AddTicks(2558), "", 45, "Villa vista a la piscina", 4, 100.0 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
