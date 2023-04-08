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
            Console.WriteLine("3 - Ver Menu Completo");
            Console.WriteLine("4 - Consultar un pedido");
            Console.WriteLine("5 - salir del restaurante");

            Console.Write("Ingresa tu opcion a continuacion: ");
            int opcionElegida = int.Parse(Console.ReadLine());

            elegirOpcion(opcionElegida);
        }

        private void elegirOpcion(int opcion)
        {
            switch(opcion)
            {
                case 1: restauran.hacerPedido(); optionsLabel(); break; //mejorar metodo
                    case 2: restauran.verPedidos(); optionsLabel(); break;
                        case 3: restauran.VerMercaderias(); optionsLabel(); break;
                            case 4: restauran.consultarPedido(); optionsLabel(); break;
                                case 5: Console.Clear(); Console.WriteLine("Esperamos verte pronto!! "); break;
            }
        }

    }
}
