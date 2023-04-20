using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class test : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_ComandaMercaderia",
                table: "ComandaMercaderia");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ComandaMercaderia",
                table: "ComandaMercaderia",
                column: "ComandaMercaderiaId");

            migrationBuilder.CreateIndex(
                name: "IX_ComandaMercaderia_MercaderiaId",
                table: "ComandaMercaderia",
                column: "MercaderiaId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_ComandaMercaderia",
                table: "ComandaMercaderia");

            migrationBuilder.DropIndex(
                name: "IX_ComandaMercaderia_MercaderiaId",
                table: "ComandaMercaderia");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ComandaMercaderia",
                table: "ComandaMercaderia",
                columns: new[] { "MercaderiaId", "ComandaId" });
        }
    }
}
