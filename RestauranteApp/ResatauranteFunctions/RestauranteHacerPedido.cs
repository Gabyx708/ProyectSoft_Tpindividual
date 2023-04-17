using Application.Interfaces;
using Application.Services;
using Domain.Entities;
using Infrastructure.Commands;
using Infrastructure.Querys;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestauranteApp.ResatauranteFunctions
{
    public class RestauranteHacerPedido
    {
        private IComandaService service = new ComandaService(new ComandaCommand(),new ComandaQuery());
        private IComandaMercaderiaService serviceComandaMercaderia = new ComandaMercaderiaService(new ComandaMercaderiaCommand(),new ComandaMercaderiaQuery());

        private void crearPedido(List<Mercaderia>Platillos,FormaEntrega FormaDeEntrega)
        {
            int PrecioTotal = 0;
            DateTime Fecha = DateTime.Now;

            foreach (Mercaderia mercaderia in Platillos)
            {
                PrecioTotal = mercaderia.Precio + PrecioTotal;
            }

            Comanda nuevaComanda = service.CreateComanda(FormaDeEntrega,PrecioTotal,Fecha);

            foreach (Mercaderia mercaderia in Platillos)
            {
                serviceComandaMercaderia.CreateComandaMercaderia(mercaderia.MercaderiaId, nuevaComanda.ComandaId);
            }

            notificarComanda(nuevaComanda);
        }

        public void hacerUnPedido()
        {   
            Console.WriteLine("\n Elige los platillos del menu utilizando su Codigo (para finalizar escribe O): ");
            Console.Write("ingresa el codigo del platillo: ");
            int PlatilloElegido = int.Parse(Console.ReadLine());

            var mercaderias = new MercaderiaService(new MercaderiaCommand(), new MercaderiaQuery());
            List<Mercaderia> listaDePlatillos = new List<Mercaderia>();

            while (PlatilloElegido != 0)
            {
                listaDePlatillos.Add(mercaderias.GetById(PlatilloElegido));
                Console.Write("ingresa el codigo del platillo: ");
                PlatilloElegido = int.Parse(Console.ReadLine());
                

            }

            Console.WriteLine("\n A continuacion ingresa el codigo la forma en la que quieres que entreguemos tu pedido: ");
            RestauranteFormasDeEntrega EntregaPedido = new RestauranteFormasDeEntrega();
            List<FormaEntrega> Entregas = EntregaPedido.FormaEntregas();

            foreach (var entrega in Entregas)
            {
                Console.WriteLine(entrega.FormaEntregaId + " - " + entrega.Descripcion);
            }

            Console.Write("ingresa el codigo del forma de entrega: ");
            int FormaEntregaElegida = int.Parse(Console.ReadLine());

            crearPedido(listaDePlatillos, EntregaPedido.UsarFormaEntrega(FormaEntregaElegida));
        }

        private void notificarComanda(Comanda NuevaComanda)
        {
            Console.WriteLine("\n!En hora buena , su pedido se ah generado con exito!");
            Console.WriteLine("*************************************************************************************");
            Console.WriteLine("PEDIDO COD: " + NuevaComanda.ComandaId + " A PAGAR: U$D: $" + NuevaComanda.PrecioTotal);
            Console.WriteLine("forma de entrega: "+NuevaComanda.FormaEntrega.Descripcion);
            Console.WriteLine("*************************************************************************************\n");
        }
    }
}
