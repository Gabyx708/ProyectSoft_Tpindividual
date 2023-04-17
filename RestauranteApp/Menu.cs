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
        private Restaurante restauran = Restaurante.GetInstance();

        public void Handle()
        {
            Console.WriteLine("***************************************");
            Console.WriteLine("****** BINEVENID@ A " + restauran.Name + " ***");
            Console.WriteLine("***************************************");
        }

        public void OptionsLabel()
        {
            Console.WriteLine("Elige una opcion para continuar: ");
            Console.WriteLine("1 - Realizar un pedido");
            Console.WriteLine("2 - Ver Pedidos");
            Console.WriteLine("3 - Ver Menu Completo");
            Console.WriteLine("4 - Consultar un pedido");
            Console.WriteLine("5 - salir del restaurante");

            Console.Write("Ingresa tu opcion a continuacion: ");
            int opcionElegida = int.Parse(Console.ReadLine());

            ElegirOpcion(opcionElegida);
        }

        private void ElegirOpcion(int opcion)
        {
            switch(opcion)
            {
                case 1: restauran.HacerPedido(); OptionsLabel(); break; //mejorar metodo
                    case 2: restauran.VerPedidos(); OptionsLabel(); break;
                        case 3: restauran.VerMercaderias(); OptionsLabel(); break;
                            case 4: restauran.ConsultarPedido(); OptionsLabel(); break;
                                case 5: Console.Clear(); Console.WriteLine("Esperamos verte pronto!! "); break;
            }
        }

    }
}
