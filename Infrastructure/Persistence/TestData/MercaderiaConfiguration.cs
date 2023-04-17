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
                    new Mercaderia { MercaderiaId= 1,Nombre= "Pizza de cebolla", TipoMercaderiaId=5,Precio=500,Ingredientes="cebolla",Preparacion=prepacion,Imagen=imagen},
                    new Mercaderia { MercaderiaId = 2, Nombre = "Hamburguesa vegana", TipoMercaderiaId = 2, Precio = 100, Ingredientes = "verduras", Preparacion = prepacion, Imagen = imagen },
                    new Mercaderia { MercaderiaId = 3, Nombre = "Ensalada César", TipoMercaderiaId = 7, Precio = 200, Ingredientes = "tomates", Preparacion = prepacion, Imagen = imagen },
                    new Mercaderia { MercaderiaId = 4, Nombre = "Sushi", TipoMercaderiaId = 1, Precio = 900, Ingredientes = "pescado", Preparacion = prepacion, Imagen = imagen },
                    new Mercaderia { MercaderiaId = 5, Nombre = "Pollo a la parrilla", TipoMercaderiaId = 1, Precio = 700, Ingredientes = "pollo", Preparacion = prepacion, Imagen = imagen },
                    new Mercaderia { MercaderiaId = 6, Nombre = "Fajitas de pollo", TipoMercaderiaId = 1, Precio = 800, Ingredientes = "pollito", Preparacion = prepacion, Imagen = imagen },
                    new Mercaderia { MercaderiaId = 7, Nombre = "Tacos", TipoMercaderiaId = 1, Precio = 900, Ingredientes = "tortilla", Preparacion = prepacion, Imagen = imagen },
                    new Mercaderia { MercaderiaId = 8, Nombre = "Spaghetti a la boloñesa", TipoMercaderiaId = 1, Precio = 100, Ingredientes = "fideos", Preparacion = prepacion, Imagen = imagen },
                    new Mercaderia { MercaderiaId = 9, Nombre = "Paella", TipoMercaderiaId = 1, Precio = 900, Ingredientes = "papas", Preparacion = prepacion, Imagen = imagen },
                    new Mercaderia { MercaderiaId = 10, Nombre = "Curry de pollo", TipoMercaderiaId = 1, Precio = 200, Ingredientes = "sal", Preparacion = prepacion, Imagen = imagen },
                    new Mercaderia { MercaderiaId = 11, Nombre = "Fideos chinos salteados", TipoMercaderiaId = 1, Precio = 900, Ingredientes = "fideo chino", Preparacion = prepacion, Imagen = imagen },
                    new Mercaderia { MercaderiaId = 12, Nombre = "Chili con carne", TipoMercaderiaId = 1, Precio = 300, Ingredientes = "chilis", Preparacion = prepacion, Imagen = imagen },
                    new Mercaderia { MercaderiaId = 13, Nombre = "Arroz con frijoles", TipoMercaderiaId = 1, Precio = 900, Ingredientes = "frijoles", Preparacion = prepacion, Imagen = imagen },
                    new Mercaderia { MercaderiaId = 14, Nombre = "Carne asada", TipoMercaderiaId = 1, Precio = 600, Ingredientes = "carne de vaca", Preparacion = prepacion, Imagen = imagen },
                    new Mercaderia { MercaderiaId = 15, Nombre = "Filete de salmón a la parrilla", TipoMercaderiaId = 1, Precio = 300, Ingredientes = "filete", Preparacion = prepacion, Imagen = imagen },
                    new Mercaderia { MercaderiaId = 16, Nombre = "Guiso de carne", TipoMercaderiaId = 1, Precio = 100, Ingredientes = "fideos tirabuzon", Preparacion = prepacion, Imagen = imagen },
                    new Mercaderia { MercaderiaId = 17, Nombre = "Estofado de verduras", TipoMercaderiaId = 1, Precio = 700, Ingredientes = "lechuga", Preparacion = prepacion, Imagen = imagen },
                    new Mercaderia { MercaderiaId = 18, Nombre = "Empanadas", TipoMercaderiaId = 1, Precio = 800, Ingredientes = "tapa de empanada", Preparacion = prepacion, Imagen = imagen },
                    new Mercaderia { MercaderiaId = 19, Nombre = "Sandwich de pavo", TipoMercaderiaId = 1, Precio = 600, Ingredientes = "pavo", Preparacion = prepacion, Imagen = imagen },
                    new Mercaderia { MercaderiaId = 20, Nombre = "Tortilla de patatas", TipoMercaderiaId = 1, Precio = 100, Ingredientes = "papas", Preparacion = prepacion, Imagen = imagen }



                );
        }
    }
}
