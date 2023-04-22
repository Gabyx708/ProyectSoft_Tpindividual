using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Persistence.TestData
{
    public class MercaderiaConfiguration : IEntityTypeConfiguration<Mercaderia>
    {
        private string prepacion = "es un secreto..";
        private string imagen = "un foton..";
        public void Configure(EntityTypeBuilder<Mercaderia> builder)
        {
            builder.HasData
                (
                    new Mercaderia { 
                        MercaderiaId= 1,
                        Nombre= "Pizza de cebolla", 
                        TipoMercaderiaId=5,Precio=500,
                        Ingredientes="cebolla , harina , queso ,agua",
                        Preparacion= "cubre masa con salsa, cebolla en rodajas y queso. Hornea a 200°C por 10-12 min ¡Listo",
                        Imagen= "https://img-global.cpcdn.com/recipes/7772e784ee260031/400x400cq70/photo.jpg" },

                    new Mercaderia { 
                        MercaderiaId = 2, 
                        Nombre = "Hamburguesa vegana", 
                        TipoMercaderiaId = 4, Precio = 100, 
                        Ingredientes = "frigoles , pan rallado , cebolla , harina", 
                        Preparacion = "mezcla frijoles negros cocidos, cebolla, ajo, pan rallado y forma la hamburguesa. Cocina a la parrilla o sartén. ¡Disfruta!", 
                        Imagen = "https://i0.wp.com/veganista.es/wp-content/uploads/2018/04/IMG_20180424_141630.jpg" },

                    new Mercaderia { 
                        MercaderiaId = 3, 
                        Nombre = "Ensalada César", 
                        TipoMercaderiaId = 7, Precio = 200, 
                        Ingredientes = "queso parmesano , lechuga", 
                        Preparacion = "mezcla lechuga romana, aderezo César, queso parmesano y croutones. Opcional: pollo a la parrilla. ¡Deliciosa!", 
                        Imagen = "https://www.gourmet.cl/wp-content/uploads/2016/09/Ensalada_C%C3%A9sar-web-553x458.jpg" },

                    new Mercaderia { 
                        MercaderiaId = 4, 
                        Nombre = "Sushi", 
                        TipoMercaderiaId = 1, Precio = 900, 
                        Ingredientes = "arroz , pescado",
                        Preparacion = "cocine arroz para sushi. Enrolle en alga nori con pescado crudo o vegetales. Cortar en rodajas. Servir con salsa de soja y wasabi", 
                        Imagen = "https://assets.tmecosys.com/image/upload/t_web767x639/img/recipe/ras/Assets/0749D9BC-260D-40F4-A07F-54814C4A82B4/Derivates/A73A7793-F3EE-4B90-ABA4-1CC1A0C3E18F.jpg" },

                    new Mercaderia { 
                        MercaderiaId = 5, 
                        Nombre = "Pollo a la parrilla", 
                        TipoMercaderiaId = 1, Precio = 700, 
                        Ingredientes = "pollo , hierbas , sal , pimienta", 
                        Preparacion = "sazona el pollo con sal, pimienta y hierbas. Asa a fuego medio-alto durante 6-8 min por cada lado. ¡Listo para disfrutar!", 
                        Imagen = "https://comidasperuanas.net/wp-content/uploads/2020/12/Pollo-a-la-parrilla-peruano.jpg" },

                    new Mercaderia { 
                        MercaderiaId = 6, 
                        Nombre = "Fajitas de pollo", 
                        TipoMercaderiaId = 2, Precio = 800, 
                        Ingredientes = "pollo , pimienta , cebolla",
                        Preparacion = "corta el pollo en tiras y saltear con pimiento y cebolla en una sartén con aceite. Agrega condimentos al gusto. Sirve en tortillas y disfruta", 
                        Imagen = "https://www.recetasderechupete.com/wp-content/uploads/2014/05/fajitas_pollo.jpg" },

                    new Mercaderia { 
                        MercaderiaId = 7,
                        Nombre = "Tacos",
                        TipoMercaderiaId = 1, Precio = 900, 
                        Ingredientes = "carne molido , chile en polvo , condimentos", 
                        Preparacion = "cocina carne molida con condimentos mexicanos, como comino y chile en polvo. Sirve en tortillas con cilantro, cebolla, lima y salsa. ¡Buen provecho!",
                        Imagen = "https://pronacatqma.com/images/com_yoorecipe/banner_superior/8545_1.jpg" },

                    new Mercaderia { 
                        MercaderiaId = 8, 
                        Nombre = "Spaghetti a la boloñesa", 
                        TipoMercaderiaId = 3, Precio = 100, 
                        Ingredientes = "pasta , cebolla , ajo",
                        Preparacion = "cocina la pasta. Sofríe carne molida con cebolla y ajo. Agrega tomate triturado y cocine a fuego lento. Sirve la salsa sobre la pasta y decora con queso parmesano rallado. ¡Buen apetito!", 
                        Imagen = "https://workweeklunch.com/wp-content/uploads/2022/10/spaghetti.bolognese-4.jpg"
                    },

                    new Mercaderia { 
                        MercaderiaId = 9, 
                        Nombre = "Paella", 
                        TipoMercaderiaId = 1, Precio = 900, 
                        Ingredientes = "arroz , pimiento , caldo de pollo", 
                        Preparacion = "sofríe ajo, cebolla y pimiento en aceite. Agrega arroz, caldo de pollo, azafrán y condimentos. Añade mariscos, pollo y guisantes. Cocine a fuego lento hasta que el arroz esté tierno. ¡Disfruta de la auténtica paella!", 
                        Imagen = "https://www.nestleprofessional-latam.com/sites/default/files/styles/np_recipe_detail/public/2022-07/paella.png" },

                    new Mercaderia { 
                        MercaderiaId = 10, 
                        Nombre = "Curry de pollo", 
                        TipoMercaderiaId = 1, Precio = 200, 
                        Ingredientes = "sal , cebolla , ajo", 
                        Preparacion = "saltea cebolla, ajo y jengibre en aceite. Agrega pollo cortado en cubos y curry en polvo. Agrega tomates y leche de coco. Cocine a fuego lento hasta que el pollo esté tierno. Sirve con arroz. ¡Buen provecho!", 
                        Imagen = "https://i.blogs.es/9ea7a4/pollo_curry-copia/650_1200.jpg" },

                    new Mercaderia { 
                        MercaderiaId = 11, 
                        Nombre = "Fideos chinos salteados", 
                        TipoMercaderiaId = 1, Precio = 900, 
                        Ingredientes = "fideos , cebolla , pimiento", 
                        Preparacion = "cocine los fideos y escurrir. Saltear cebolla, pimiento, zanahoria y champiñones en aceite. Agregue los fideos y salsa de soja. Opcional: carne o camarones. ¡Listo para servir!", 
                        Imagen = "https://cdn5.recetasdeescandalo.com/wp-content/uploads/2020/08/Chow-mein-de-pollo-y-verduras-unos-fideos-chinos-salteados-riquisimos.jpg" },

                    new Mercaderia { 
                        MercaderiaId = 12,
                        Nombre = "Chili con carne", 
                        TipoMercaderiaId = 1, Precio = 300, 
                        Ingredientes = "cebolla , ajo , frijoles rojos",
                        Preparacion = " sofríe carne molida con cebolla y ajo. Agrega frijoles rojos, tomate triturado, pimiento y comino. Cocina a fuego lento durante 30-40 min. Sirve con arroz y queso rallado", 
                        Imagen = "https://cdn6.recetasdeescandalo.com/wp-content/uploads/2020/04/Chili-con-carne-muy-facil-y-con-mucho-sabor.jpg" },

                    new Mercaderia { 
                        MercaderiaId = 13, 
                        Nombre = "Arroz con frijoles", 
                        TipoMercaderiaId = 1, Precio = 900, 
                        Ingredientes = "frijoles , arroz", 
                        Preparacion = "cocina arroz y frijoles en una olla. Sofríe cebolla, ajo y pimiento en aceite. Agrega la mezcla de arroz y frijoles a la sartén y cocina a fuego lento durante 10-15 min.", 
                        Imagen = "https://www.petitchef.es/imgupl/recipe/arroz-con-frijoles-comida-cubana--md-208520p323903.jpg" },

                    new Mercaderia { 
                        MercaderiaId = 14, 
                        Nombre = "Carne asada", 
                        TipoMercaderiaId = 1, Precio = 600, 
                        Ingredientes = "carne de vaca , sal , pimienta , ajo", 
                        Preparacion = "Sazona carne con sal, pimienta y ajo. Asa en parrilla caliente 4-5 min cada lado. Reposar 5-10 min antes de cortar", 
                        Imagen = "https://images-gmi-pmc.edge-generalmills.com/cc1e665a-027a-42e1-8e8a-9b27eaf358b9.jpg" },

                    new Mercaderia { 
                        MercaderiaId = 15, 
                        Nombre = "Filete de salmón a la parrilla", 
                        TipoMercaderiaId = 1, Precio = 300, 
                        Ingredientes = "salmon , sal , pimienta", 
                        Preparacion = " sazona el salmón con sal, pimienta y limón. Asa a fuego medio-alto durante 4-5 min por cada lado o hasta que esté dorado por fuera y cocido por dentro. Sirve con vegetales a la parrilla", 
                        Imagen="https://images-gmi-pmc.edge-generalmills.com/33c536a0-9743-4e5b-b867-e4b0d89abab2.jpg" },

                    new Mercaderia { 
                        MercaderiaId = 16, 
                        Nombre = "Guiso de carne", 
                        TipoMercaderiaId = 1, Precio = 100, 
                        Ingredientes = "fideos , carne , aceite", 
                        Preparacion = "corta la carne en cubos y saltea en una olla con aceite. Agrega cebolla, ajo, zanahoria, pimiento y papas en cubos. Agrega caldo, tomate triturado y hierbas. Cocina a fuego lento durante 1-2 horas", 
                        Imagen="https://images.hola.com/imagenes/cocina/recetas/20191007150968/guiso-patatas-con-carne/0-729-270/patatas-carne-m.jpg" },

                    new Mercaderia { 
                        MercaderiaId = 17, 
                        Nombre = "Estofado de verduras", 
                        TipoMercaderiaId = 1, Precio = 700,
                        Ingredientes = "lechuga , cebolla , ajo", 
                        Preparacion = "saltea cebolla y ajo en una olla con aceite. Agrega zanahoria, papa y calabaza en cubos. Agrega caldo, tomate triturado y hierbas. Cocina a fuego lento durante 30-40 min.", 
                        Imagen = "https://content-cocina.lecturas.com/medio/2018/07/19/paso-a-paso-para-hacer-estofado-de-verduras-con-champinones-y-jamon-resultado-final_775e1b9d_800x800.jpg" },

                    new Mercaderia { 
                        MercaderiaId = 18, 
                        Nombre = "Empanadas", 
                        TipoMercaderiaId = 2, Precio = 800, 
                        Ingredientes = "tapa de empanada", 
                        Preparacion = "mezcla carne molida con cebolla, ajo, pimiento y condimentos. Corta masa de empanadas y rellena con la mezcla de carne. Cierra y cocina en el horno a 200°C durante 20-25 min.", 
                        Imagen = "https://tastesbetterfromscratch.com/wp-content/uploads/2020/05/Empanadas-2.jpg" },

                    new Mercaderia { MercaderiaId = 19, 
                        Nombre = "Sandwich de pavo", 
                        TipoMercaderiaId = 1, Precio = 600, 
                        Ingredientes = "pavo , queso , mostaza",
                        Preparacion = "tuesta pan de trigo. Agrega pechuga de pavo, tomate, lechuga, queso y mostaza", 
                        Imagen = "https://cdn0.recetasgratis.net/es/posts/7/2/0/sandwich_de_pavo_y_queso_55027_orig.jpg"
                    },

                    new Mercaderia { 
                        MercaderiaId = 20, 
                        Nombre = "Tortilla de patatas", 
                        TipoMercaderiaId = 1, Precio = 100, 
                        Ingredientes = "papas , cebolla", 
                        Preparacion = "saltea cebolla y papas en rodajas en una sartén con aceite. Batir huevos y agregar a la sartén. Cocine a fuego lento hasta que la tortilla esté cocida. Dale la vuelta para cocinar ambos lados", 
                        Imagen = "https://www.clarin.com/img/2022/05/16/W9sHDNg6p_340x340__1.jpg"
                    }

                );
        }
    }
}
