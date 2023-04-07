using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class cargaDeTipoDeMercaderia : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "FormaEntregas",
                columns: new[] { "FormaEntregaId", "Descripcion" },
                values: new object[,]
                {
                    { 10, "Salon" },
                    { 20, "Delivery" },
                    { 30, "Pedidos Ya" }
                });

            migrationBuilder.InsertData(
                table: "TipoMercaderias",
                columns: new[] { "TipoMercaderiaId", "Descripcion" },
                values: new object[,]
                {
                    { 1, "Entrada" },
                    { 2, "Minutas" },
                    { 3, "Pastas" },
                    { 4, "Parilla" },
                    { 5, "Pizzas" },
                    { 6, "Sandwich" },
                    { 7, "Ensaladas" },
                    { 8, "Bebidas" },
                    { 9, "Cerveza artesanal" },
                    { 10, "Postres" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "FormaEntregas",
                keyColumn: "FormaEntregaId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "FormaEntregas",
                keyColumn: "FormaEntregaId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "FormaEntregas",
                keyColumn: "FormaEntregaId",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "TipoMercaderias",
                keyColumn: "TipoMercaderiaId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "TipoMercaderias",
                keyColumn: "TipoMercaderiaId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "TipoMercaderias",
                keyColumn: "TipoMercaderiaId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "TipoMercaderias",
                keyColumn: "TipoMercaderiaId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "TipoMercaderias",
                keyColumn: "TipoMercaderiaId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "TipoMercaderias",
                keyColumn: "TipoMercaderiaId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "TipoMercaderias",
                keyColumn: "TipoMercaderiaId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "TipoMercaderias",
                keyColumn: "TipoMercaderiaId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "TipoMercaderias",
                keyColumn: "TipoMercaderiaId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "TipoMercaderias",
                keyColumn: "TipoMercaderiaId",
                keyValue: 10);

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
    }
}
