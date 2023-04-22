using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class initdatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FormaEntrega",
                columns: table => new
                {
                    FormaEntregaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descripcion = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FormaEntrega", x => x.FormaEntregaId);
                });

            migrationBuilder.CreateTable(
                name: "TipoMercaderia",
                columns: table => new
                {
                    TipoMercaderiaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descripcion = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoMercaderia", x => x.TipoMercaderiaId);
                });

            migrationBuilder.CreateTable(
                name: "Comanda",
                columns: table => new
                {
                    ComandaId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FormaEntregaId = table.Column<int>(type: "int", nullable: false),
                    PrecioTotal = table.Column<int>(type: "int", nullable: false),
                    Fecha = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comanda", x => x.ComandaId);
                    table.ForeignKey(
                        name: "FK_Comanda_FormaEntrega_FormaEntregaId",
                        column: x => x.FormaEntregaId,
                        principalTable: "FormaEntrega",
                        principalColumn: "FormaEntregaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Mercaderia",
                columns: table => new
                {
                    MercaderiaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    TipoMercaderiaId = table.Column<int>(type: "int", nullable: false),
                    Precio = table.Column<int>(type: "int", nullable: false),
                    Ingredientes = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Preparacion = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Imagen = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mercaderia", x => x.MercaderiaId);
                    table.ForeignKey(
                        name: "FK_Mercaderia_TipoMercaderia_TipoMercaderiaId",
                        column: x => x.TipoMercaderiaId,
                        principalTable: "TipoMercaderia",
                        principalColumn: "TipoMercaderiaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ComandaMercaderia",
                columns: table => new
                {
                    ComandaMercaderiaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ComandaId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MercaderiaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ComandaMercaderia", x => x.ComandaMercaderiaId);
                    table.ForeignKey(
                        name: "FK_ComandaMercaderia_Comanda_ComandaId",
                        column: x => x.ComandaId,
                        principalTable: "Comanda",
                        principalColumn: "ComandaId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ComandaMercaderia_Mercaderia_MercaderiaId",
                        column: x => x.MercaderiaId,
                        principalTable: "Mercaderia",
                        principalColumn: "MercaderiaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "FormaEntrega",
                columns: new[] { "FormaEntregaId", "Descripcion" },
                values: new object[,]
                {
                    { 1, "Salon" },
                    { 2, "Delivery" },
                    { 3, "Pedidos Ya" }
                });

            migrationBuilder.InsertData(
                table: "TipoMercaderia",
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

            migrationBuilder.InsertData(
                table: "Mercaderia",
                columns: new[] { "MercaderiaId", "Imagen", "Ingredientes", "Nombre", "Precio", "Preparacion", "TipoMercaderiaId" },
                values: new object[,]
                {
                    { 1, "https://img-global.cpcdn.com/recipes/7772e784ee260031/400x400cq70/photo.jpg", "cebolla , harina , queso ,agua", "Pizza de cebolla", 500, "cubre masa con salsa, cebolla en rodajas y queso. Hornea a 200°C por 10-12 min ¡Listo", 5 },
                    { 2, "https://i0.wp.com/veganista.es/wp-content/uploads/2018/04/IMG_20180424_141630.jpg?resize=624%2C509", "frigoles , pan rallado , cebolla , harina", "Hamburguesa vegana", 100, "mezcla frijoles negros cocidos, cebolla, ajo, pan rallado y forma la hamburguesa. Cocina a la parrilla o sartén. ¡Disfruta!", 2 },
                    { 3, "https://www.gourmet.cl/wp-content/uploads/2016/09/Ensalada_C%C3%A9sar-web-553x458.jpg", "queso parmesano , lechuga", "Ensalada César", 200, "mezcla lechuga romana, aderezo César, queso parmesano y croutones. Opcional: pollo a la parrilla. ¡Deliciosa!", 7 },
                    { 4, "https://assets.tmecosys.com/image/upload/t_web767x639/img/recipe/ras/Assets/0749D9BC-260D-40F4-A07F-54814C4A82B4/Derivates/A73A7793-F3EE-4B90-ABA4-1CC1A0C3E18F.jpg", "arroz , pescado", "Sushi", 900, "cocine arroz para sushi. Enrolle en alga nori con pescado crudo o vegetales. Cortar en rodajas. Servir con salsa de soja y wasabi", 1 },
                    { 5, "https://comidasperuanas.net/wp-content/uploads/2020/12/Pollo-a-la-parrilla-peruano.jpg", "pollo , hierbas , sal , pimienta", "Pollo a la parrilla", 700, "sazona el pollo con sal, pimienta y hierbas. Asa a fuego medio-alto durante 6-8 min por cada lado. ¡Listo para disfrutar!", 1 },
                    { 6, "https://www.recetasderechupete.com/wp-content/uploads/2014/05/fajitas_pollo.jpg", "pollo , pimienta , cebolla", "Fajitas de pollo", 800, "corta el pollo en tiras y saltear con pimiento y cebolla en una sartén con aceite. Agrega condimentos al gusto. Sirve en tortillas y disfruta", 1 },
                    { 7, "https://pronacatqma.com/images/com_yoorecipe/banner_superior/8545_1.jpg", "carne molido , chile en polvo , condimentos", "Tacos", 900, "cocina carne molida con condimentos mexicanos, como comino y chile en polvo. Sirve en tortillas con cilantro, cebolla, lima y salsa. ¡Buen provecho!", 1 },
                    { 8, "https://cdn7.kiwilimon.com/recetaimagen/30306/960x640/33677.jpg.jpg", "pasta , cebolla , ajo", "Spaghetti a la boloñesa", 100, "cocina la pasta. Sofríe carne molida con cebolla y ajo. Agrega tomate triturado y cocine a fuego lento. Sirve la salsa sobre la pasta y decora con queso parmesano rallado. ¡Buen apetito!", 1 },
                    { 9, "https://www.nestleprofessional-latam.com/sites/default/files/styles/np_recipe_detail/public/2022-07/paella.png?itok=CBvKkcsa", "arroz , pimiento , caldo de pollo", "Paella", 900, "sofríe ajo, cebolla y pimiento en aceite. Agrega arroz, caldo de pollo, azafrán y condimentos. Añade mariscos, pollo y guisantes. Cocine a fuego lento hasta que el arroz esté tierno. ¡Disfruta de la auténtica paella!", 1 },
                    { 10, "https://i.blogs.es/9ea7a4/pollo_curry-copia/650_1200.jpg", "sal , cebolla , ajo", "Curry de pollo", 200, "saltea cebolla, ajo y jengibre en aceite. Agrega pollo cortado en cubos y curry en polvo. Agrega tomates y leche de coco. Cocine a fuego lento hasta que el pollo esté tierno. Sirve con arroz. ¡Buen provecho!", 1 },
                    { 11, "https://cdn5.recetasdeescandalo.com/wp-content/uploads/2020/08/Chow-mein-de-pollo-y-verduras-unos-fideos-chinos-salteados-riquisimos.jpg", "fideos , cebolla , pimiento", "Fideos chinos salteados", 900, "cocine los fideos y escurrir. Saltear cebolla, pimiento, zanahoria y champiñones en aceite. Agregue los fideos y salsa de soja. Opcional: carne o camarones. ¡Listo para servir!", 1 },
                    { 12, "https://cdn6.recetasdeescandalo.com/wp-content/uploads/2020/04/Chili-con-carne-muy-facil-y-con-mucho-sabor.jpg", "cebolla , ajo , frijoles rojos", "Chili con carne", 300, " sofríe carne molida con cebolla y ajo. Agrega frijoles rojos, tomate triturado, pimiento y comino. Cocina a fuego lento durante 30-40 min. Sirve con arroz y queso rallado", 1 },
                    { 13, "https://www.petitchef.es/imgupl/recipe/arroz-con-frijoles-comida-cubana--md-208520p323903.jpg", "frijoles , arroz", "Arroz con frijoles", 900, "cocina arroz y frijoles en una olla. Sofríe cebolla, ajo y pimiento en aceite. Agrega la mezcla de arroz y frijoles a la sartén y cocina a fuego lento durante 10-15 min.", 1 },
                    { 14, "https://images-gmi-pmc.edge-generalmills.com/cc1e665a-027a-42e1-8e8a-9b27eaf358b9.jpg", "carne de vaca , sal , pimienta , ajo", "Carne asada", 600, "Sazona carne con sal, pimienta y ajo. Asa en parrilla caliente 4-5 min cada lado. Reposar 5-10 min antes de cortar", 1 },
                    { 15, "https://images-gmi-pmc.edge-generalmills.com/33c536a0-9743-4e5b-b867-e4b0d89abab2.jpg", "salmon , sal , pimienta", "Filete de salmón a la parrilla", 300, " sazona el salmón con sal, pimienta y limón. Asa a fuego medio-alto durante 4-5 min por cada lado o hasta que esté dorado por fuera y cocido por dentro. Sirve con vegetales a la parrilla", 1 },
                    { 16, "https://images.hola.com/imagenes/cocina/recetas/20191007150968/guiso-patatas-con-carne/0-729-270/patatas-carne-m.jpg", "fideos , carne , aceite", "Guiso de carne", 100, "corta la carne en cubos y saltea en una olla con aceite. Agrega cebolla, ajo, zanahoria, pimiento y papas en cubos. Agrega caldo, tomate triturado y hierbas. Cocina a fuego lento durante 1-2 horas", 1 },
                    { 17, "https://content-cocina.lecturas.com/medio/2018/07/19/paso-a-paso-para-hacer-estofado-de-verduras-con-champinones-y-jamon-resultado-final_775e1b9d_800x800.jpg", "lechuga , cebolla , ajo", "Estofado de verduras", 700, "saltea cebolla y ajo en una olla con aceite. Agrega zanahoria, papa y calabaza en cubos. Agrega caldo, tomate triturado y hierbas. Cocina a fuego lento durante 30-40 min.", 1 },
                    { 18, "https://tastesbetterfromscratch.com/wp-content/uploads/2020/05/Empanadas-2.jpg", "tapa de empanada", "Empanadas", 800, "mezcla carne molida con cebolla, ajo, pimiento y condimentos. Corta masa de empanadas y rellena con la mezcla de carne. Cierra y cocina en el horno a 200°C durante 20-25 min.", 1 },
                    { 19, "https://hips.hearstapps.com/hmg-prod.s3.amazonaws.com/images/ham-and-cheese-sandwich-royalty-free-image-1609846416.?crop=1.00xw:1.00xh;0,0&resize=640:*", "pavo , queso , mostaza", "Sandwich de pavo", 600, "tuesta pan de trigo. Agrega pechuga de pavo, tomate, lechuga, queso y mostaza", 1 },
                    { 20, "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcS4VJEEZcpMPvS7ovEhw0oH8O-6LmpLetpa6A&usqp=CAU", "papas , cebolla", "Tortilla de patatas", 100, "saltea cebolla y papas en rodajas en una sartén con aceite. Batir huevos y agregar a la sartén. Cocine a fuego lento hasta que la tortilla esté cocida. Dale la vuelta para cocinar ambos lados", 1 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Comanda_FormaEntregaId",
                table: "Comanda",
                column: "FormaEntregaId");

            migrationBuilder.CreateIndex(
                name: "IX_ComandaMercaderia_ComandaId",
                table: "ComandaMercaderia",
                column: "ComandaId");

            migrationBuilder.CreateIndex(
                name: "IX_ComandaMercaderia_MercaderiaId",
                table: "ComandaMercaderia",
                column: "MercaderiaId");

            migrationBuilder.CreateIndex(
                name: "IX_Mercaderia_TipoMercaderiaId",
                table: "Mercaderia",
                column: "TipoMercaderiaId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ComandaMercaderia");

            migrationBuilder.DropTable(
                name: "Comanda");

            migrationBuilder.DropTable(
                name: "Mercaderia");

            migrationBuilder.DropTable(
                name: "FormaEntrega");

            migrationBuilder.DropTable(
                name: "TipoMercaderia");
        }
    }
}
