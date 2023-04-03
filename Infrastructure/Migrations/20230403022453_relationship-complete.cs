using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class relationshipcomplete : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Comandas_FormaEntregaId",
                table: "Comandas");

            migrationBuilder.CreateIndex(
                name: "IX_Mercaderias_TipoMercaderiaId",
                table: "Mercaderias",
                column: "TipoMercaderiaId");

            migrationBuilder.CreateIndex(
                name: "IX_Comandas_FormaEntregaId",
                table: "Comandas",
                column: "FormaEntregaId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Mercaderias_TipoMercaderias_TipoMercaderiaId",
                table: "Mercaderias",
                column: "TipoMercaderiaId",
                principalTable: "TipoMercaderias",
                principalColumn: "TipoMercaderiaId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Mercaderias_TipoMercaderias_TipoMercaderiaId",
                table: "Mercaderias");

            migrationBuilder.DropIndex(
                name: "IX_Mercaderias_TipoMercaderiaId",
                table: "Mercaderias");

            migrationBuilder.DropIndex(
                name: "IX_Comandas_FormaEntregaId",
                table: "Comandas");

            migrationBuilder.CreateIndex(
                name: "IX_Comandas_FormaEntregaId",
                table: "Comandas",
                column: "FormaEntregaId");
        }
    }
}
