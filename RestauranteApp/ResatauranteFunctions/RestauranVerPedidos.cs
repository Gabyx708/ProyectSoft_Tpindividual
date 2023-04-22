using Application.Interfaces;
using Application.Services;
using Domain.Entities;
using Infrastructure.Commands;
using Infrastructure.Querys;

namespace RestauranteApp.ResatauranteFunctions
{
    public class RestauranVerPedidos : Utilities
    {
        private readonly IComandaService _service;
        private readonly IMercaderiaService _serviceMercaderia;
        private readonly IFormaEntregaService _serviceEntrega;
        private readonly IComandaMercaderiaService _serviceComandaMercaderia;

        public RestauranVerPedidos()
        {
            _service = new ComandaService(new ComandaCommand(), new ComandaQuery()); ;
            _serviceMercaderia = new MercaderiaService(new MercaderiaCommand(), new MercaderiaQuery()); ;
            _serviceEntrega = new FormaEntregaServices(new FormaEntregaCommand(), new FormaEntregaQuery()); ;
            _serviceComandaMercaderia = new ComandaMercaderiaService(new ComandaMercaderiaCommand(), new ComandaMercaderiaQuery()); ;
        }


        public void ConsultarPedido()
        {
            CleanConsola();
            Console.Write("\n ingresa el CODIGO DEL PEDIDO O  TIPEA X PARA CANCELAR: ");
            string Codigo = Console.ReadLine();
            Comanda Comanda = null;

            if (Codigo == "x" || Codigo == "X")
            {
                BackHome();
            }

            try
            {
                Comanda = _service.GetById(Guid.Parse(Codigo));

                if (Comanda == null)
                {
                    throw new NullReferenceException();
                }
            }
            catch (Exception e)
            {
                string Comment = "el id ingresado no es valido , o esta en el formato incorrecto";
                ErrorNotify(e.Message, Comment);
                ConsultarPedido();
            }

            List<ComandaMercaderia> Union = _serviceComandaMercaderia.GetByComandaId(Comanda.ComandaId);

            Console.WriteLine("\n ***PEDIDO CONSULTADO***");
            Console.WriteLine("| COD: " + Comanda.ComandaId + " fecha: " + Comanda.Fecha + " |");
            Console.WriteLine("| ----------- DETALLE DEL PEDIDO  ------------------- |");


            foreach (var plato in Union)
            {
                Mercaderia itemDePedido = _serviceMercaderia.GetById(plato.MercaderiaId);

                Console.WriteLine("Descripcion: " + itemDePedido.Nombre + "------ $" + itemDePedido.Precio);
            }

            Console.WriteLine("\n| entrega: " + _serviceEntrega.GetById(Comanda.FormaEntregaId).Descripcion + " TOTAL U$D: $" + Comanda.PrecioTotal + "|");
            Console.WriteLine(" ");
        }

        public void ListarPedidos()
        {
            CleanConsola();
            List<Comanda> Pedidos = _service.GetAll();

            foreach (var item in Pedidos)
            {
                Comanda Comanda = _service.GetById(item.ComandaId);
                List<ComandaMercaderia> Union = _serviceComandaMercaderia.GetByComandaId(Comanda.ComandaId);


                Console.WriteLine("\n");
                Console.WriteLine("| COD: " + Comanda.ComandaId + " fecha: " + Comanda.Fecha + " |");
                Console.WriteLine("| ----------- DETALLE DEL PEDIDO  ------------------- |");


                foreach (var plato in Union)
                {
                    Mercaderia itemDePedido = _serviceMercaderia.GetById(plato.MercaderiaId);

                    Console.WriteLine("Descripcion: " + itemDePedido.Nombre + "------ $" + itemDePedido.Precio);
                }

                Console.WriteLine("\n| entrega: " + _serviceEntrega.GetById(Comanda.FormaEntregaId).Descripcion + " TOTAL U$D: $" + Comanda.PrecioTotal + "|");
                Console.WriteLine("\n ");
            }
        }
    }


}
