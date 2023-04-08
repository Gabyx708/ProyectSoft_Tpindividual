using RestauranteApp.ResatauranteFunctions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestauranteApp
{
    internal class Restaurante
    {
        private static Restaurante instance = null;
        private string name = "Los antegelitos";
        public static Restaurante getInstance()
        {
            if(instance == null)
            {
                instance = new Restaurante();
            }
            return instance;
        }

        public string Name
        { get { return name; } }

        public void VerMercaderias()
        {
            new RestauranteVerMercaderias().listarMercaderia();
        }

    }
}
