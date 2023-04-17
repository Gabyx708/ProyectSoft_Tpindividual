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
    public class RestauranVerPedidos
    {
        private IComandaService service = new ComandaService(new ComandaCommand(),new ComandaQuery());
        private IMercaderiaService serviceMercaderia = new MercaderiaService(new MercaderiaCommand(),new MercaderiaQuery());
        private IFormaEntregaService serviceEntrega = new FormaEntregaServices(new FormaEntregaCommand(),new FormaEntregaQuery());
        private IComandaMercaderiaService serviceComandaMercaderia = new ComandaMercaderiaService(new ComandaMercaderiaCommand(),new ComandaMercaderiaQuery());

        public void consultarPedido()
        {
            Console.Write("\n ingresa el CODIGO DEL PEDIDO: ");
            string codigo = Console.ReadLine();
            
            Comanda comanda =  service.GetById(Guid.Parse(codigo));
            List<ComandaMercaderia> union = serviceComandaMercaderia.GetByComandaId(comanda.ComandaId);

            Console.WriteLine("\n ***PEDIDO CONSULTADO***");
            Console.WriteLine("| COD: "+comanda.ComandaId+" fecha: "+comanda.Fecha+" |");
            Console.WriteLine("| ----------- DETALLE DEL PEDIDO  ------------------- |");
           
            
            foreach (var plato in union)
            {
               Mercaderia itemDePedido =  serviceMercaderia.GetById(plato.MercaderiaId);

                Console.WriteLine("Descripcion: "+itemDePedido.Nombre+"------ $"+itemDePedido.Precio);
            }

            Console.WriteLine("\n| entrega: "+serviceEntrega.GetById(comanda.FormaEntregaId).Descripcion+" TOTAL U$D: $"+comanda.PrecioTotal+"|");
            Console.WriteLine(" ");
        }

        public void listarPedidos()
        {
            List<Comanda> pedidos = service.GetAll();

            foreach (var item in pedidos) 
            {
                Comanda comanda = service.GetById(item.ComandaId);
                List<ComandaMercaderia> union = serviceComandaMercaderia.GetByComandaId(comanda.ComandaId);


                Console.WriteLine("\n");
                Console.WriteLine("| COD: " + comanda.ComandaId + " fecha: " + comanda.Fecha + " |");
                Console.WriteLine("| ----------- DETALLE DEL PEDIDO  ------------------- |");


                foreach (var plato in union)
                {
                    Mercaderia itemDePedido = serviceMercaderia.GetById(plato.MercaderiaId);

                    Console.WriteLine("Descripcion: " + itemDePedido.Nombre + "------ $" + itemDePedido.Precio);
                }

                Console.WriteLine("\n| entrega: " + serviceEntrega.GetById(comanda.FormaEntregaId).Descripcion + " TOTAL U$D: $" + comanda.PrecioTotal + "|");
                Console.WriteLine("\n ");
            }
        }
    }

   
}
