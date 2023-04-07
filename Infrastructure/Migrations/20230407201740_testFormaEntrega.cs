using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class testFormaEntrega : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "FormaEntregas",
                columns: new[] { "FormaEntregaId", "Descripcion" },
                values: new object[,]
                {
                    { 34, "Pedidos Ya" },
                    { 45, "Salon" },
                    { 90, "Delivery" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "FormaEntregas",
                keyColumn: "FormaEntregaId",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "FormaEntregas",
                keyColumn: "FormaEntregaId",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "FormaEntregas",
                keyColumn: "FormaEntregaId",
                keyValue: 90);
        }
    }
}
