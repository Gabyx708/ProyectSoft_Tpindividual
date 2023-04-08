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

        public void elegirOpcion(int opcion)
        {
            switch(opcion)
            {
                case 1: restauran.VerMercaderias(); break;
                    case 2: Console.WriteLine(); break;
            }
        }



        private void matar()
        {
            Console.WriteLine("te mate!!");
        }
    }
}
