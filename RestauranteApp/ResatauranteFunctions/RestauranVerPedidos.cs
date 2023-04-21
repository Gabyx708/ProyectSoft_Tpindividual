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
    public class RestauranVerPedidos : Utilities
    {
        private readonly IComandaService service = new ComandaService(new ComandaCommand(),new ComandaQuery());
        private readonly IMercaderiaService serviceMercaderia = new MercaderiaService(new MercaderiaCommand(),new MercaderiaQuery());
        private readonly IFormaEntregaService serviceEntrega = new FormaEntregaServices(new FormaEntregaCommand(),new FormaEntregaQuery());
        private readonly IComandaMercaderiaService serviceComandaMercaderia = new ComandaMercaderiaService(new ComandaMercaderiaCommand(),new ComandaMercaderiaQuery());

        public void ConsultarPedido()
        {
            Console.Write("\n ingresa el CODIGO DEL PEDIDO O  TIPEA X PARA CANCELAR: ");
            string Codigo = Console.ReadLine();
            Comanda Comanda = null;

            if (Codigo == "x" || Codigo == "X")
            {
                BackHome();
            }

            try
            {
               Comanda = service.GetById(Guid.Parse(Codigo));

                if (Comanda == null)
                {
                    throw new NullReferenceException();
                }
            }
            catch (Exception e)
            {
                string Comment = "el id ingresado no es valido , o esta en el formato incorrecto";
                ErrorNotify(e.Message,Comment);
                ConsultarPedido();
            }
            
            List<ComandaMercaderia> Union = serviceComandaMercaderia.GetByComandaId(Comanda.ComandaId);

            Console.WriteLine("\n ***PEDIDO CONSULTADO***");
            Console.WriteLine("| COD: "+Comanda.ComandaId+" fecha: "+Comanda.Fecha+" |");
            Console.WriteLine("| ----------- DETALLE DEL PEDIDO  ------------------- |");
           
            
            foreach (var plato in Union)
            {
               Mercaderia itemDePedido =  serviceMercaderia.GetById(plato.MercaderiaId);

                Console.WriteLine("Descripcion: "+itemDePedido.Nombre+"------ $"+itemDePedido.Precio);
            }

            Console.WriteLine("\n| entrega: "+serviceEntrega.GetById(Comanda.FormaEntregaId).Descripcion+" TOTAL U$D: $"+Comanda.PrecioTotal+"|");
            Console.WriteLine(" ");
        }

        public void ListarPedidos()
        {
            List<Comanda> Pedidos = service.GetAll();

            foreach (var item in Pedidos) 
            {
                Comanda Comanda = service.GetById(item.ComandaId);
                List<ComandaMercaderia> Union = serviceComandaMercaderia.GetByComandaId(Comanda.ComandaId);


                Console.WriteLine("\n");
                Console.WriteLine("| COD: " + Comanda.ComandaId + " fecha: " + Comanda.Fecha + " |");
                Console.WriteLine("| ----------- DETALLE DEL PEDIDO  ------------------- |");


                foreach (var plato in Union)
                {
                    Mercaderia itemDePedido = serviceMercaderia.GetById(plato.MercaderiaId);

                    Console.WriteLine("Descripcion: " + itemDePedido.Nombre + "------ $" + itemDePedido.Precio);
                }

                Console.WriteLine("\n| entrega: " + serviceEntrega.GetById(Comanda.FormaEntregaId).Descripcion + " TOTAL U$D: $" + Comanda.PrecioTotal + "|");
                Console.WriteLine("\n ");
            }
        }
    }

   
}
