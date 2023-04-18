using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestauranteApp.ResatauranteFunctions
{
    public class CleanConsole
    {
        private CleanConsole instance = null;
        public CleanConsole GetInstance()
        {
            if (instance == null)
            {
                instance = new CleanConsole();
            }
            return instance;
        }

        public void CleanConsola()
        {
            Console.Clear();
            Console.WriteLine("----------------------------------");
        }
    }
}
