using Domain.Entities;
using Infrastructure.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace RestauranteApp
{
    public class prepareData
    {
        private AppDbcontext context = AppDbcontext.getInstance();
        public bool  FormaEntregaData()
        {           

            context.Add(new FormaEntrega { Descripcion = "Salon" });
            context.Add(new FormaEntrega { Descripcion = "Delivery" });
            context.Add(new FormaEntrega { Descripcion = "Pedidos Ya" });

           
            if (context.SaveChanges() != 1)
            {
                return false;
            }

            return true;
        }

        public bool TipoMercaderiaData()
        {
            context.Add(new TipoMercaderia {TipoMercaderiaId= 40, Descripcion = "Entrada" });
            context.Add(new TipoMercaderia { Descripcion = "Minutas" });
            context.Add(new TipoMercaderia { Descripcion = "Pastas" });
            context.Add(new TipoMercaderia { Descripcion = "Parrilla" });
            context.Add(new TipoMercaderia { Descripcion = "Pizza" });
            context.Add(new TipoMercaderia { Descripcion = "Sandwich" });
            context.Add(new TipoMercaderia { Descripcion = "Ensaladas" });
            context.Add(new TipoMercaderia { Descripcion = "Bebidas" });
            context.Add(new TipoMercaderia { Descripcion = "Cerveza Artesanal" });
            context.Add(new TipoMercaderia { Descripcion = "Postres" });

            if(context.SaveChanges() != 1)
            {
                return false;
            }

            return true;
        }

    }
}
