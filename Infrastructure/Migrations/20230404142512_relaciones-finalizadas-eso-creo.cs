using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class relacionesfinalizadasesocreo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Comandas_FormaEntregaId",
                table: "Comandas");

            migrationBuilder.CreateIndex(
                name: "IX_Comandas_FormaEntregaId",
                table: "Comandas",
                column: "FormaEntregaId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Comandas_FormaEntregaId",
                table: "Comandas");

            migrationBuilder.CreateIndex(
                name: "IX_Comandas_FormaEntregaId",
                table: "Comandas",
                column: "FormaEntregaId",
                unique: true);
        }
    }
}
