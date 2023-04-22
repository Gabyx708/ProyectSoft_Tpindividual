using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestauranteApp.ResatauranteFunctions
{
    public class Utilities
    {
        public void CleanConsola()
        {
            Console.Clear();
            Console.WriteLine("---------------------------------------");
        }

        public void ErrorNotify(string ExceptionMessage, string Comment)
        {
            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine("Ups! ocurrio un error inesperado: " + ExceptionMessage);
            Console.WriteLine("Se recomienda: " + Comment + "\n");
            Console.WriteLine("----------------------------------------------------------");
        }

        public void BackHome()
        {
            Menu Aux = Menu.GetInstance();
            Aux.OptionsLabel();
        }
    }
}
