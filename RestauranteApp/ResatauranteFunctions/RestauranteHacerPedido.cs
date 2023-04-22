using Application.Interfaces;
using Application.Services;
using Domain.Entities;
using Infrastructure.Commands;
using Infrastructure.Querys;
using System.Security.Cryptography.X509Certificates;

namespace RestauranteApp.ResatauranteFunctions
{
    public class RestauranteHacerPedido : Utilities
    {
        private readonly IComandaService _service;
        private readonly IComandaMercaderiaService _serviceComandaMercaderia;
        private readonly IMercaderiaService _serviceMercaderia;

        public RestauranteHacerPedido()
        {
            _service = new ComandaService(new ComandaCommand(), new ComandaQuery()); ;
            _serviceComandaMercaderia = new ComandaMercaderiaService(new ComandaMercaderiaCommand(), new ComandaMercaderiaQuery()); ;
            _serviceMercaderia = new MercaderiaService(new MercaderiaCommand(), new MercaderiaQuery()); ;
        }

        private void CrearPedido(List<Mercaderia> Platillos, FormaEntrega FormaDeEntrega)
        {
            int PrecioTotal = 0;
            DateTime Fecha = DateTime.Now;


            foreach (Mercaderia mercaderia in Platillos)
            {
                PrecioTotal = mercaderia.Precio + PrecioTotal;
            }

            Comanda nuevaComanda = _service.CreateComanda(FormaDeEntrega, PrecioTotal, Fecha);

            foreach (Mercaderia mercaderia in Platillos)
            {
                _serviceComandaMercaderia.CreateComandaMercaderia(mercaderia.MercaderiaId, nuevaComanda.ComandaId);
            }

            NotificarComanda(nuevaComanda);
        }

        public void HacerUnPedido()
        {
            int PlatilloElegido;
            bool FlagError = false;
            int LimiteId = _serviceMercaderia.GetAll().Count();

            var mercaderias = new MercaderiaService(new MercaderiaCommand(), new MercaderiaQuery());
            List<Mercaderia> listaDePlatillos = new List<Mercaderia>();

            try
            {
                Console.Write("\n Elige los platillos del menu utilizando su Codigo (para finalizar escribe O): ");
                PlatilloElegido = int.Parse(Console.ReadLine());
                
                if (PlatilloElegido == 0 || PlatilloElegido == null)
                {
                    throw new InvalidDataException();
                }

                while (PlatilloElegido != 0)
                {
                    if (mercaderias.GetById(PlatilloElegido) == null)
                    {
                        throw new InvalidDataException();
                    }

                    listaDePlatillos.Add(mercaderias.GetById(PlatilloElegido));
                    Console.Write("\n Elige los platillos del menu utilizando su Codigo (para finalizar escribe O): ");
                    PlatilloElegido = int.Parse(Console.ReadLine());
                }
            }
            catch (Exception e)
            {
                string Comment = "Ups! ocurrio un problema por favor intenta crear tu pedido de nuevo";
                FlagError = true;
                ErrorNotify(e.Message, Comment);
                BackHome();
            }

            if (FlagError == false)
            {
                ElegirFormaEntrega(listaDePlatillos);
            }
            
        }

        private void ElegirFormaEntrega(List<Mercaderia> listaDePlatillos)
        {
            Console.WriteLine("\n A continuacion ingresa el codigo la forma en la que quieres que entreguemos tu pedido: ");
            RestauranteFormasDeEntrega EntregaPedido = new RestauranteFormasDeEntrega();
            List<FormaEntrega> Entregas = EntregaPedido.FormaEntregas();
            int limiteIdEntregas = Entregas.Count();

            foreach (var entrega in Entregas)
            {
                Console.WriteLine(entrega.FormaEntregaId + " - " + entrega.Descripcion);
            }

            try
            {
                Console.Write("ingresa el codigo del forma de entrega: ");
                int FormaEntregaElegida = int.Parse(Console.ReadLine());

                if (FormaEntregaElegida > 0 && FormaEntregaElegida <= limiteIdEntregas)
                {
                    CrearPedido(listaDePlatillos, EntregaPedido.UsarFormaEntrega(FormaEntregaElegida));
                }
                else
                {
                    throw new IndexOutOfRangeException();
                }
            }
            catch (Exception e)
            {
                string Comment = "Ups! tu forma de entrega fue invalida , realiza el pedido nuevamente!";
                ErrorNotify(e.Message, Comment);
                BackHome();
            }
        }

        private void NotificarComanda(Comanda NuevaComanda)
        {
            CleanConsola();
            Console.WriteLine("\n!En hora buena , su pedido se ah generado con exito!");
            Console.WriteLine("*************************************************************************************");
            Console.WriteLine("PEDIDO COD: " + NuevaComanda.ComandaId + " A PAGAR: U$D: $" + NuevaComanda.PrecioTotal);
            Console.WriteLine("forma de entrega: " + NuevaComanda.FormaEntrega.Descripcion);
            Console.WriteLine("*************************************************************************************\n");
        }
    }
}
