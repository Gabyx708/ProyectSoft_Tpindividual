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
    public class Menu : Utilities
    {
        private Restaurante _restauran = Restaurante.GetInstance();
        private static Menu instance = null;

        public static Menu GetInstance()
        {
            if (instance == null)
            {
                instance = new Menu();
            }
            return instance;
        }

        public void Handle()
        {
            Console.WriteLine("***************************************");
            Console.WriteLine("****** BINEVENID@ A " + _restauran.Name + " ***");
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

            try
            {
                int opcionElegida = int.Parse(Console.ReadLine());

                if (opcionElegida > 5 || opcionElegida < 1)
                {
                    throw new ArgumentOutOfRangeException();
                }

                ElegirOpcion(opcionElegida);
         
            }
            catch (Exception e)
            {
                string Comment = "solo usar numeros que esten dentro de las opciones validas";
                ErrorNotify(e.Message,Comment);
                OptionsLabel();
            }
                      
        }

        private void ElegirOpcion(int opcion)
        {
            switch(opcion)
            {
                case 1: _restauran.HacerPedido(); OptionsLabel(); break; //mejorar metodo
                    case 2: _restauran.VerPedidos(); OptionsLabel(); break;
                        case 3: _restauran.VerMercaderias(); OptionsLabel(); break;
                            case 4: _restauran.ConsultarPedido(); OptionsLabel(); break;
                                case 5: CleanConsola(); Console.WriteLine("Esperamos verte pronto!! "); break;
            }
        }

    }
}
