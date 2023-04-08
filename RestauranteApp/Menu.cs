using Application.Services;
using Domain.Entities;
using Infrastructure.Commands;
using Infrastructure.Querys;
using RestauranteApp.ResatauranteFunctions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestauranteApp
{
    internal class Menu
    {
        private Restaurante restauran = Restaurante.getInstance();

        public void handle()
        {
            Console.WriteLine("***************************************");
            Console.WriteLine("****** BINEVENID@ A " + restauran.Name + " ***");
            Console.WriteLine("***************************************");
        }

        public void optionsLabel()
        {
            Console.WriteLine("Elige una opcion para continuar: ");
            Console.WriteLine("1 - Realizar un pedido");
            Console.WriteLine("2 - Ver Pedidos");
            Console.WriteLine("3- Ver Menu Completo");
            Console.WriteLine("4 - salir del restaurante");

            Console.Write("Ingresa tu opcion a continuacion: ");
            int opcionElegida = int.Parse(Console.ReadLine());

            elegirOpcion(opcionElegida);
        }

        private void elegirOpcion(int opcion)
        {
            switch(opcion)
            {
                case 1: pedirComida(); break;
                    case 2: Console.WriteLine(); break;
                        case 3: restauran.VerMercaderias(); break;
                            case 4: Console.WriteLine(); break;
            }
        }



        private void pedirComida()
        {
            restauran.VerMercaderias();
            Console.WriteLine("\n Elige los platillos del menu utilizando su Codigo (para finalizar escribe O): ");
            int platilloElegido = int.Parse(Console.ReadLine());

            var mercaderias = new MercaderiaService(new MercaderiaCommand(), new MercaderiaQuery());
            List<Mercaderia> listaDePlatillos = new List<Mercaderia>();

            while (platilloElegido !=0)
            {
               listaDePlatillos.Add(mercaderias.getById(platilloElegido));
               platilloElegido = int.Parse(Console.ReadLine());

            }

            Console.WriteLine("\n A continuacion ingresa el codigo la forma en la que quieres que entreguemos tu pedido: ");
            RestauranteFormasDeEntrega entregaPedido = new RestauranteFormasDeEntrega();
            List<FormaEntrega> entregas =  entregaPedido.formaEntregas();

            foreach (var entrega in entregas)
            {
                Console.WriteLine(entrega.FormaEntregaId+" - "+entrega.Descripcion);
            }

            int FormaEntregaElegida = int.Parse(Console.ReadLine());

            new RestauranteHacerPedido().crearPedido(listaDePlatillos,entregaPedido.usarFormaEntrega(FormaEntregaElegida));
        }
    }
}
