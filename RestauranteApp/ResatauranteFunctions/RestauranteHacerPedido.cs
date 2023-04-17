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

        private void crearPedido(List<Mercaderia>platillos,FormaEntrega formaDeEntrega)
        {
            int precioTotal = 0;
            DateTime fecha = DateTime.Now;

            foreach (Mercaderia mercaderia in platillos)
            {
                precioTotal = mercaderia.Precio + precioTotal;
            }

            Comanda nuevaComanda = service.CreateComanda(formaDeEntrega,precioTotal,fecha);

            foreach (Mercaderia mercaderia in platillos)
            {
                serviceComandaMercaderia.CreateComandaMercaderia(mercaderia.MercaderiaId, nuevaComanda.ComandaId);
            }

            notificarComanda(nuevaComanda);
        }

        public void hacerUnPedido()
        {   
            Console.WriteLine("\n Elige los platillos del menu utilizando su Codigo (para finalizar escribe O): ");
            Console.Write("ingresa el codigo del platillo: ");
            int platilloElegido = int.Parse(Console.ReadLine());

            var mercaderias = new MercaderiaService(new MercaderiaCommand(), new MercaderiaQuery());
            List<Mercaderia> listaDePlatillos = new List<Mercaderia>();

            while (platilloElegido != 0)
            {
                listaDePlatillos.Add(mercaderias.GetById(platilloElegido));
                Console.Write("ingresa el codigo del platillo: ");
                platilloElegido = int.Parse(Console.ReadLine());
                

            }

            Console.WriteLine("\n A continuacion ingresa el codigo la forma en la que quieres que entreguemos tu pedido: ");
            RestauranteFormasDeEntrega entregaPedido = new RestauranteFormasDeEntrega();
            List<FormaEntrega> entregas = entregaPedido.formaEntregas();

            foreach (var entrega in entregas)
            {
                Console.WriteLine(entrega.FormaEntregaId + " - " + entrega.Descripcion);
            }

            Console.Write("ingresa el codigo del forma de entrega: ");
            int FormaEntregaElegida = int.Parse(Console.ReadLine());

            crearPedido(listaDePlatillos, entregaPedido.usarFormaEntrega(FormaEntregaElegida));
        }

        private void notificarComanda(Comanda nuevaComanda)
        {
            Console.WriteLine("\n!En hora buena , su pedido se ah generado con exito!");
            Console.WriteLine("*************************************************************************************");
            Console.WriteLine("PEDIDO COD: " + nuevaComanda.ComandaId + " A PAGAR: U$D: $" + nuevaComanda.PrecioTotal);
            Console.WriteLine("forma de entrega: "+nuevaComanda.FormaEntrega.Descripcion);
            Console.WriteLine("*************************************************************************************\n");
        }
    }
}
