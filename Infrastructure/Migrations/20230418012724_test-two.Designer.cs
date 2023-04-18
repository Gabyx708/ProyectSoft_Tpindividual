﻿// <auto-generated />
using System;
using Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Infrastructure.Migrations
{
    [DbContext(typeof(AppDbcontext))]
    [Migration("20230418012724_test-two")]
    partial class testtwo
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Domain.Entities.Comanda", b =>
                {
                    b.Property<Guid>("ComandaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime2");

                    b.Property<int>("FormaEntregaId")
                        .HasColumnType("int");

                    b.Property<int>("PrecioTotal")
                        .HasColumnType("int");

                    b.HasKey("ComandaId");

                    b.HasIndex("FormaEntregaId");

                    b.ToTable("Comanda", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.ComandaMercaderia", b =>
                {
                    b.Property<int>("MercaderiaId")
                        .HasColumnType("int");

                    b.Property<Guid>("ComandaId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("ComandaMercaderiaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ComandaMercaderiaId"));

                    b.HasKey("MercaderiaId", "ComandaId");

                    b.HasIndex("ComandaId");

                    b.ToTable("ComandaMercaderia", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.FormaEntrega", b =>
                {
                    b.Property<int>("FormaEntregaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("FormaEntregaId"));

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("FormaEntregaId");

                    b.ToTable("FormaEntrega", (string)null);

                    b.HasData(
                        new
                        {
                            FormaEntregaId = 1,
                            Descripcion = "Salon"
                        },
                        new
                        {
                            FormaEntregaId = 2,
                            Descripcion = "Delivery"
                        },
                        new
                        {
                            FormaEntregaId = 3,
                            Descripcion = "Pedidos Ya"
                        });
                });

            modelBuilder.Entity("Domain.Entities.Mercaderia", b =>
                {
                    b.Property<int>("MercaderiaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MercaderiaId"));

                    b.Property<string>("Imagen")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Ingredientes")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("Precio")
                        .HasColumnType("int");

                    b.Property<string>("Preparacion")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<int>("TipoMercaderiaId")
                        .HasColumnType("int");

                    b.HasKey("MercaderiaId");

                    b.HasIndex("TipoMercaderiaId");

                    b.ToTable("Mercaderia", (string)null);

                    b.HasData(
                        new
                        {
                            MercaderiaId = 1,
                            Imagen = "https://img-global.cpcdn.com/recipes/7772e784ee260031/400x400cq70/photo.jpg",
                            Ingredientes = "cebolla , harina , queso ,agua",
                            Nombre = "Pizza de cebolla",
                            Precio = 500,
                            Preparacion = "cubre masa con salsa, cebolla en rodajas y queso. Hornea a 200°C por 10-12 min ¡Listo",
                            TipoMercaderiaId = 5
                        },
                        new
                        {
                            MercaderiaId = 2,
                            Imagen = "https://i0.wp.com/veganista.es/wp-content/uploads/2018/04/IMG_20180424_141630.jpg?resize=624%2C509",
                            Ingredientes = "frigoles , pan rallado , cebolla , harina",
                            Nombre = "Hamburguesa vegana",
                            Precio = 100,
                            Preparacion = "mezcla frijoles negros cocidos, cebolla, ajo, pan rallado y forma la hamburguesa. Cocina a la parrilla o sartén. ¡Disfruta!",
                            TipoMercaderiaId = 2
                        },
                        new
                        {
                            MercaderiaId = 3,
                            Imagen = "https://www.gourmet.cl/wp-content/uploads/2016/09/Ensalada_C%C3%A9sar-web-553x458.jpg",
                            Ingredientes = "queso parmesano , lechuga",
                            Nombre = "Ensalada César",
                            Precio = 200,
                            Preparacion = "mezcla lechuga romana, aderezo César, queso parmesano y croutones. Opcional: pollo a la parrilla. ¡Deliciosa!",
                            TipoMercaderiaId = 7
                        },
                        new
                        {
                            MercaderiaId = 4,
                            Imagen = "https://assets.tmecosys.com/image/upload/t_web767x639/img/recipe/ras/Assets/0749D9BC-260D-40F4-A07F-54814C4A82B4/Derivates/A73A7793-F3EE-4B90-ABA4-1CC1A0C3E18F.jpg",
                            Ingredientes = "arroz , pescado",
                            Nombre = "Sushi",
                            Precio = 900,
                            Preparacion = "cocine arroz para sushi. Enrolle en alga nori con pescado crudo o vegetales. Cortar en rodajas. Servir con salsa de soja y wasabi",
                            TipoMercaderiaId = 1
                        },
                        new
                        {
                            MercaderiaId = 5,
                            Imagen = "https://comidasperuanas.net/wp-content/uploads/2020/12/Pollo-a-la-parrilla-peruano.jpg",
                            Ingredientes = "pollo , hierbas , sal , pimienta",
                            Nombre = "Pollo a la parrilla",
                            Precio = 700,
                            Preparacion = "sazona el pollo con sal, pimienta y hierbas. Asa a fuego medio-alto durante 6-8 min por cada lado. ¡Listo para disfrutar!",
                            TipoMercaderiaId = 1
                        },
                        new
                        {
                            MercaderiaId = 6,
                            Imagen = "https://www.recetasderechupete.com/wp-content/uploads/2014/05/fajitas_pollo.jpg",
                            Ingredientes = "pollo , pimienta , cebolla",
                            Nombre = "Fajitas de pollo",
                            Precio = 800,
                            Preparacion = "corta el pollo en tiras y saltear con pimiento y cebolla en una sartén con aceite. Agrega condimentos al gusto. Sirve en tortillas y disfruta",
                            TipoMercaderiaId = 1
                        },
                        new
                        {
                            MercaderiaId = 7,
                            Imagen = "https://pronacatqma.com/images/com_yoorecipe/banner_superior/8545_1.jpg",
                            Ingredientes = "carne molido , chile en polvo , condimentos",
                            Nombre = "Tacos",
                            Precio = 900,
                            Preparacion = "cocina carne molida con condimentos mexicanos, como comino y chile en polvo. Sirve en tortillas con cilantro, cebolla, lima y salsa. ¡Buen provecho!",
                            TipoMercaderiaId = 1
                        },
                        new
                        {
                            MercaderiaId = 8,
                            Imagen = "https://cdn7.kiwilimon.com/recetaimagen/30306/960x640/33677.jpg.jpg",
                            Ingredientes = "pasta , cebolla , ajo",
                            Nombre = "Spaghetti a la boloñesa",
                            Precio = 100,
                            Preparacion = "cocina la pasta. Sofríe carne molida con cebolla y ajo. Agrega tomate triturado y cocine a fuego lento. Sirve la salsa sobre la pasta y decora con queso parmesano rallado. ¡Buen apetito!",
                            TipoMercaderiaId = 1
                        },
                        new
                        {
                            MercaderiaId = 9,
                            Imagen = "https://www.nestleprofessional-latam.com/sites/default/files/styles/np_recipe_detail/public/2022-07/paella.png?itok=CBvKkcsa",
                            Ingredientes = "arroz , pimiento , caldo de pollo",
                            Nombre = "Paella",
                            Precio = 900,
                            Preparacion = "sofríe ajo, cebolla y pimiento en aceite. Agrega arroz, caldo de pollo, azafrán y condimentos. Añade mariscos, pollo y guisantes. Cocine a fuego lento hasta que el arroz esté tierno. ¡Disfruta de la auténtica paella!",
                            TipoMercaderiaId = 1
                        },
                        new
                        {
                            MercaderiaId = 10,
                            Imagen = "https://i.blogs.es/9ea7a4/pollo_curry-copia/650_1200.jpg",
                            Ingredientes = "sal , cebolla , ajo",
                            Nombre = "Curry de pollo",
                            Precio = 200,
                            Preparacion = "saltea cebolla, ajo y jengibre en aceite. Agrega pollo cortado en cubos y curry en polvo. Agrega tomates y leche de coco. Cocine a fuego lento hasta que el pollo esté tierno. Sirve con arroz. ¡Buen provecho!",
                            TipoMercaderiaId = 1
                        },
                        new
                        {
                            MercaderiaId = 11,
                            Imagen = "https://cdn5.recetasdeescandalo.com/wp-content/uploads/2020/08/Chow-mein-de-pollo-y-verduras-unos-fideos-chinos-salteados-riquisimos.jpg.webp",
                            Ingredientes = "fideos , cebolla , pimiento",
                            Nombre = "Fideos chinos salteados",
                            Precio = 900,
                            Preparacion = "cocine los fideos y escurrir. Saltear cebolla, pimiento, zanahoria y champiñones en aceite. Agregue los fideos y salsa de soja. Opcional: carne o camarones. ¡Listo para servir!",
                            TipoMercaderiaId = 1
                        },
                        new
                        {
                            MercaderiaId = 12,
                            Imagen = "https://cdn6.recetasdeescandalo.com/wp-content/uploads/2020/04/Chili-con-carne-muy-facil-y-con-mucho-sabor.jpg",
                            Ingredientes = "cebolla , ajo , frijoles rojos",
                            Nombre = "Chili con carne",
                            Precio = 300,
                            Preparacion = " sofríe carne molida con cebolla y ajo. Agrega frijoles rojos, tomate triturado, pimiento y comino. Cocina a fuego lento durante 30-40 min. Sirve con arroz y queso rallado",
                            TipoMercaderiaId = 1
                        },
                        new
                        {
                            MercaderiaId = 13,
                            Imagen = "https://www.petitchef.es/imgupl/recipe/arroz-con-frijoles-comida-cubana--md-208520p323903.jpg",
                            Ingredientes = "frijoles , arroz",
                            Nombre = "Arroz con frijoles",
                            Precio = 900,
                            Preparacion = "cocina arroz y frijoles en una olla. Sofríe cebolla, ajo y pimiento en aceite. Agrega la mezcla de arroz y frijoles a la sartén y cocina a fuego lento durante 10-15 min.",
                            TipoMercaderiaId = 1
                        },
                        new
                        {
                            MercaderiaId = 14,
                            Imagen = "https://images-gmi-pmc.edge-generalmills.com/cc1e665a-027a-42e1-8e8a-9b27eaf358b9.jpg",
                            Ingredientes = "carne de vaca , sal , pimienta , ajo",
                            Nombre = "Carne asada",
                            Precio = 600,
                            Preparacion = "Sazona carne con sal, pimienta y ajo. Asa en parrilla caliente 4-5 min cada lado. Reposar 5-10 min antes de cortar",
                            TipoMercaderiaId = 1
                        },
                        new
                        {
                            MercaderiaId = 15,
                            Imagen = "https://images-gmi-pmc.edge-generalmills.com/33c536a0-9743-4e5b-b867-e4b0d89abab2.jpg",
                            Ingredientes = "salmon , sal , pimienta",
                            Nombre = "Filete de salmón a la parrilla",
                            Precio = 300,
                            Preparacion = " sazona el salmón con sal, pimienta y limón. Asa a fuego medio-alto durante 4-5 min por cada lado o hasta que esté dorado por fuera y cocido por dentro. Sirve con vegetales a la parrilla",
                            TipoMercaderiaId = 1
                        },
                        new
                        {
                            MercaderiaId = 16,
                            Imagen = "https://images.hola.com/imagenes/cocina/recetas/20191007150968/guiso-patatas-con-carne/0-729-270/patatas-carne-m.jpg",
                            Ingredientes = "fideos , carne , aceite",
                            Nombre = "Guiso de carne",
                            Precio = 100,
                            Preparacion = "corta la carne en cubos y saltea en una olla con aceite. Agrega cebolla, ajo, zanahoria, pimiento y papas en cubos. Agrega caldo, tomate triturado y hierbas. Cocina a fuego lento durante 1-2 horas",
                            TipoMercaderiaId = 1
                        },
                        new
                        {
                            MercaderiaId = 17,
                            Imagen = "https://content-cocina.lecturas.com/medio/2018/07/19/paso-a-paso-para-hacer-estofado-de-verduras-con-champinones-y-jamon-resultado-final_775e1b9d_800x800.jpg",
                            Ingredientes = "lechuga , cebolla , ajo",
                            Nombre = "Estofado de verduras",
                            Precio = 700,
                            Preparacion = "saltea cebolla y ajo en una olla con aceite. Agrega zanahoria, papa y calabaza en cubos. Agrega caldo, tomate triturado y hierbas. Cocina a fuego lento durante 30-40 min.",
                            TipoMercaderiaId = 1
                        },
                        new
                        {
                            MercaderiaId = 18,
                            Imagen = "https://tastesbetterfromscratch.com/wp-content/uploads/2020/05/Empanadas-2.jpg",
                            Ingredientes = "tapa de empanada",
                            Nombre = "Empanadas",
                            Precio = 800,
                            Preparacion = "mezcla carne molida con cebolla, ajo, pimiento y condimentos. Corta masa de empanadas y rellena con la mezcla de carne. Cierra y cocina en el horno a 200°C durante 20-25 min.",
                            TipoMercaderiaId = 1
                        },
                        new
                        {
                            MercaderiaId = 19,
                            Imagen = "https://hips.hearstapps.com/hmg-prod.s3.amazonaws.com/images/ham-and-cheese-sandwich-royalty-free-image-1609846416.?crop=1.00xw:1.00xh;0,0&resize=640:*",
                            Ingredientes = "pavo , queso , mostaza",
                            Nombre = "Sandwich de pavo",
                            Precio = 600,
                            Preparacion = "tuesta pan de trigo. Agrega pechuga de pavo, tomate, lechuga, queso y mostaza",
                            TipoMercaderiaId = 1
                        },
                        new
                        {
                            MercaderiaId = 20,
                            Imagen = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcS4VJEEZcpMPvS7ovEhw0oH8O-6LmpLetpa6A&usqp=CAU",
                            Ingredientes = "papas , cebolla",
                            Nombre = "Tortilla de patatas",
                            Precio = 100,
                            Preparacion = "saltea cebolla y papas en rodajas en una sartén con aceite. Batir huevos y agregar a la sartén. Cocine a fuego lento hasta que la tortilla esté cocida. Dale la vuelta para cocinar ambos lados",
                            TipoMercaderiaId = 1
                        });
                });

            modelBuilder.Entity("Domain.Entities.TipoMercaderia", b =>
                {
                    b.Property<int>("TipoMercaderiaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TipoMercaderiaId"));

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("TipoMercaderiaId");

                    b.ToTable("TipoMercaderia", (string)null);

                    b.HasData(
                        new
                        {
                            TipoMercaderiaId = 1,
                            Descripcion = "Entrada"
                        },
                        new
                        {
                            TipoMercaderiaId = 2,
                            Descripcion = "Minutas"
                        },
                        new
                        {
                            TipoMercaderiaId = 3,
                            Descripcion = "Pastas"
                        },
                        new
                        {
                            TipoMercaderiaId = 4,
                            Descripcion = "Parilla"
                        },
                        new
                        {
                            TipoMercaderiaId = 5,
                            Descripcion = "Pizzas"
                        },
                        new
                        {
                            TipoMercaderiaId = 6,
                            Descripcion = "Sandwich"
                        },
                        new
                        {
                            TipoMercaderiaId = 7,
                            Descripcion = "Ensaladas"
                        },
                        new
                        {
                            TipoMercaderiaId = 8,
                            Descripcion = "Bebidas"
                        },
                        new
                        {
                            TipoMercaderiaId = 9,
                            Descripcion = "Cerveza artesanal"
                        },
                        new
                        {
                            TipoMercaderiaId = 10,
                            Descripcion = "Postres"
                        });
                });

            modelBuilder.Entity("Domain.Entities.Comanda", b =>
                {
                    b.HasOne("Domain.Entities.FormaEntrega", "FormaEntrega")
                        .WithMany("Comandas")
                        .HasForeignKey("FormaEntregaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("FormaEntrega");
                });

            modelBuilder.Entity("Domain.Entities.ComandaMercaderia", b =>
                {
                    b.HasOne("Domain.Entities.Comanda", "Comanda")
                        .WithMany("ComandaMercaderias")
                        .HasForeignKey("ComandaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.Mercaderia", "Mercaderia")
                        .WithMany("ComandaMercaderias")
                        .HasForeignKey("MercaderiaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Comanda");

                    b.Navigation("Mercaderia");
                });

            modelBuilder.Entity("Domain.Entities.Mercaderia", b =>
                {
                    b.HasOne("Domain.Entities.TipoMercaderia", "TipoMercaderia")
                        .WithMany("Mercaderias")
                        .HasForeignKey("TipoMercaderiaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("TipoMercaderia");
                });

            modelBuilder.Entity("Domain.Entities.Comanda", b =>
                {
                    b.Navigation("ComandaMercaderias");
                });

            modelBuilder.Entity("Domain.Entities.FormaEntrega", b =>
                {
                    b.Navigation("Comandas");
                });

            modelBuilder.Entity("Domain.Entities.Mercaderia", b =>
                {
                    b.Navigation("ComandaMercaderias");
                });

            modelBuilder.Entity("Domain.Entities.TipoMercaderia", b =>
                {
                    b.Navigation("Mercaderias");
                });
#pragma warning restore 612, 618
        }
    }
}
