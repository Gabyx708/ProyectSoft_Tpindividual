using Application.Interfaces;
using Application.Services;
using Domain.Entities;
using Infrastructure.Commands;
using Infrastructure.Querys;

namespace RestauranteApp.ResatauranteFunctions
{
    public class RestauranteVerMercaderias
    {

        private readonly IMercaderiaService _service;

        public RestauranteVerMercaderias()
        {
            _service = new MercaderiaService(new MercaderiaCommand(), new MercaderiaQuery()); ;
        }

        public void ListarMercaderia()
        {
            List<Mercaderia> ListaMercaderia = _service.GetAll();

            foreach (Mercaderia mercaderia in ListaMercaderia)
            {
                Console.WriteLine("************************");
                Console.WriteLine("Codigo: " + mercaderia.MercaderiaId);
                Console.WriteLine("nombre: " + mercaderia.Nombre);
                Console.WriteLine("precio U$D: " + mercaderia.Precio);
                Console.WriteLine("preparacion: " + mercaderia.Preparacion);
                Console.WriteLine("ingredientes: " + mercaderia.Ingredientes);
                Console.WriteLine("************************\n");
            }
        }

        public void ListaMercaderiaSimplificada()
        {
            List<Mercaderia> ListaMercaderia = _service.GetAll();

            foreach (Mercaderia mercaderia in ListaMercaderia)
            {
                Console.WriteLine("| Codigo: " + mercaderia.MercaderiaId + "| nombre: " + mercaderia.Nombre + "| precio U$D: " + mercaderia.Precio + "|");
            }
        }

    }
}
