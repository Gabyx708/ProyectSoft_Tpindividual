using Application.Interfaces;
using Application.Services;
using Domain.Entities;
using Infrastructure.Commands;
using Infrastructure.Querys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestauranteApp.ResatauranteFunctions
{
    public class RestauranteVerMercaderias
    {

        private IMercaderiaService service = new MercaderiaService(new MercaderiaCommand(), new MercaderiaQuery());

        public void listarMercaderia()
        {
            List<Mercaderia> listaMercaderia = service.getAll();

            foreach (Mercaderia mercaderia in listaMercaderia)
            {
                Console.WriteLine("************************");
                Console.WriteLine("Codigo: "+mercaderia.MercaderiaId);
                Console.WriteLine("nombre: "+mercaderia.Nombre);
                Console.WriteLine("precio U$D: "+mercaderia.Precio);
                Console.WriteLine("preparacion: "+mercaderia.Preparacion);
                Console.WriteLine("ingredientes: "+mercaderia.Ingredientes);
                Console.WriteLine("************************\n");
            }
        }

    }
}
