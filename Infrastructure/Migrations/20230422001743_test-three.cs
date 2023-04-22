using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class testthree : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Mercaderia",
                keyColumn: "MercaderiaId",
                keyValue: 2,
                columns: new[] { "Imagen", "TipoMercaderiaId" },
                values: new object[] { "https://i0.wp.com/veganista.es/wp-content/uploads/2018/04/IMG_20180424_141630.jpg", 4 });

            migrationBuilder.UpdateData(
                table: "Mercaderia",
                keyColumn: "MercaderiaId",
                keyValue: 6,
                column: "TipoMercaderiaId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Mercaderia",
                keyColumn: "MercaderiaId",
                keyValue: 8,
                columns: new[] { "Imagen", "TipoMercaderiaId" },
                values: new object[] { "https://workweeklunch.com/wp-content/uploads/2022/10/spaghetti.bolognese-4.jpg", 3 });

            migrationBuilder.UpdateData(
                table: "Mercaderia",
                keyColumn: "MercaderiaId",
                keyValue: 9,
                column: "Imagen",
                value: "https://www.nestleprofessional-latam.com/sites/default/files/styles/np_recipe_detail/public/2022-07/paella.png");

            migrationBuilder.UpdateData(
                table: "Mercaderia",
                keyColumn: "MercaderiaId",
                keyValue: 11,
                column: "Imagen",
                value: "https://cdn5.recetasdeescandalo.com/wp-content/uploads/2020/08/Chow-mein-de-pollo-y-verduras-unos-fideos-chinos-salteados-riquisimos.jpg");

            migrationBuilder.UpdateData(
                table: "Mercaderia",
                keyColumn: "MercaderiaId",
                keyValue: 18,
                column: "TipoMercaderiaId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Mercaderia",
                keyColumn: "MercaderiaId",
                keyValue: 19,
                column: "Imagen",
                value: "https://cdn0.recetasgratis.net/es/posts/7/2/0/sandwich_de_pavo_y_queso_55027_orig.jpg");

            migrationBuilder.UpdateData(
                table: "Mercaderia",
                keyColumn: "MercaderiaId",
                keyValue: 20,
                column: "Imagen",
                value: "https://www.clarin.com/img/2022/05/16/W9sHDNg6p_340x340__1.jpg");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Mercaderia",
                keyColumn: "MercaderiaId",
                keyValue: 2,
                columns: new[] { "Imagen", "TipoMercaderiaId" },
                values: new object[] { "https://i0.wp.com/veganista.es/wp-content/uploads/2018/04/IMG_20180424_141630.jpg?resize=624%2C509", 2 });

            migrationBuilder.UpdateData(
                table: "Mercaderia",
                keyColumn: "MercaderiaId",
                keyValue: 6,
                column: "TipoMercaderiaId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Mercaderia",
                keyColumn: "MercaderiaId",
                keyValue: 8,
                columns: new[] { "Imagen", "TipoMercaderiaId" },
                values: new object[] { "https://cdn7.kiwilimon.com/recetaimagen/30306/960x640/33677.jpg.jpg", 1 });

            migrationBuilder.UpdateData(
                table: "Mercaderia",
                keyColumn: "MercaderiaId",
                keyValue: 9,
                column: "Imagen",
                value: "https://www.nestleprofessional-latam.com/sites/default/files/styles/np_recipe_detail/public/2022-07/paella.png?itok=CBvKkcsa");

            migrationBuilder.UpdateData(
                table: "Mercaderia",
                keyColumn: "MercaderiaId",
                keyValue: 11,
                column: "Imagen",
                value: "https://cdn5.recetasdeescandalo.com/wp-content/uploads/2020/08/Chow-mein-de-pollo-y-verduras-unos-fideos-chinos-salteados-riquisimos.jpg.webp");

            migrationBuilder.UpdateData(
                table: "Mercaderia",
                keyColumn: "MercaderiaId",
                keyValue: 18,
                column: "TipoMercaderiaId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Mercaderia",
                keyColumn: "MercaderiaId",
                keyValue: 19,
                column: "Imagen",
                value: "https://hips.hearstapps.com/hmg-prod.s3.amazonaws.com/images/ham-and-cheese-sandwich-royalty-free-image-1609846416.?crop=1.00xw:1.00xh;0,0&resize=640:*");

            migrationBuilder.UpdateData(
                table: "Mercaderia",
                keyColumn: "MercaderiaId",
                keyValue: 20,
                column: "Imagen",
                value: "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcS4VJEEZcpMPvS7ovEhw0oH8O-6LmpLetpa6A&usqp=CAU");
        }
    }
}
