using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class cargaDeMercaderia : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Mercaderias",
                columns: new[] { "MercaderiaId", "Imagen", "Ingredientes", "Nombre", "Precio", "Preparacion", "TipoMercaderiaId" },
                values: new object[,]
                {
                    { 10, "un foton..", "cebolla", "Pizza de cebolla", 500, "es un secreto..", 5 },
                    { 20, "un foton..", "verduras", "Hamburguesa vegana", 100, "es un secreto..", 2 },
                    { 30, "un foton..", "tomates", "Ensalada César", 200, "es un secreto..", 7 },
                    { 40, "un foton..", "pescado", "Sushi", 900, "es un secreto..", 1 },
                    { 50, "un foton..", "pollo", "Pollo a la parrilla", 700, "es un secreto..", 1 },
                    { 60, "un foton..", "pollito", "Fajitas de pollo", 800, "es un secreto..", 1 },
                    { 70, "un foton..", "tortilla", "Tacos", 900, "es un secreto..", 1 },
                    { 80, "un foton..", "fideos", "Spaghetti a la boloñesa", 100, "es un secreto..", 1 },
                    { 90, "un foton..", "papas", "Paella", 900, "es un secreto..", 1 },
                    { 110, "un foton..", "sal", "Curry de pollo", 200, "es un secreto..", 1 },
                    { 120, "un foton..", "fideo chino", "Fideos chinos salteados", 900, "es un secreto..", 1 },
                    { 130, "un foton..", "chilis", "Chili con carne", 300, "es un secreto..", 1 },
                    { 140, "un foton..", "frijoles", "Arroz con frijoles", 900, "es un secreto..", 1 },
                    { 150, "un foton..", "carne de vaca", "Carne asada", 600, "es un secreto..", 1 },
                    { 160, "un foton..", "filete", "Filete de salmón a la parrilla", 300, "es un secreto..", 1 },
                    { 170, "un foton..", "fideos tirabuzon", "Guiso de carne", 100, "es un secreto..", 1 },
                    { 180, "un foton..", "lechuga", "Estofado de verduras", 700, "es un secreto..", 1 },
                    { 190, "un foton..", "tapa de empanada", "Empanadas", 800, "es un secreto..", 1 },
                    { 200, "un foton..", "pavo", "Sandwich de pavo", 600, "es un secreto..", 1 },
                    { 210, "un foton..", "papas", "Tortilla de patatas", 100, "es un secreto..", 1 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Mercaderias",
                keyColumn: "MercaderiaId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Mercaderias",
                keyColumn: "MercaderiaId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Mercaderias",
                keyColumn: "MercaderiaId",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Mercaderias",
                keyColumn: "MercaderiaId",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Mercaderias",
                keyColumn: "MercaderiaId",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Mercaderias",
                keyColumn: "MercaderiaId",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Mercaderias",
                keyColumn: "MercaderiaId",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Mercaderias",
                keyColumn: "MercaderiaId",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Mercaderias",
                keyColumn: "MercaderiaId",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Mercaderias",
                keyColumn: "MercaderiaId",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "Mercaderias",
                keyColumn: "MercaderiaId",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "Mercaderias",
                keyColumn: "MercaderiaId",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "Mercaderias",
                keyColumn: "MercaderiaId",
                keyValue: 140);

            migrationBuilder.DeleteData(
                table: "Mercaderias",
                keyColumn: "MercaderiaId",
                keyValue: 150);

            migrationBuilder.DeleteData(
                table: "Mercaderias",
                keyColumn: "MercaderiaId",
                keyValue: 160);

            migrationBuilder.DeleteData(
                table: "Mercaderias",
                keyColumn: "MercaderiaId",
                keyValue: 170);

            migrationBuilder.DeleteData(
                table: "Mercaderias",
                keyColumn: "MercaderiaId",
                keyValue: 180);

            migrationBuilder.DeleteData(
                table: "Mercaderias",
                keyColumn: "MercaderiaId",
                keyValue: 190);

            migrationBuilder.DeleteData(
                table: "Mercaderias",
                keyColumn: "MercaderiaId",
                keyValue: 200);

            migrationBuilder.DeleteData(
                table: "Mercaderias",
                keyColumn: "MercaderiaId",
                keyValue: 210);
        }
    }
}
