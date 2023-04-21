using Domain.Entities;
using RestauranteApp.ResatauranteFunctions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestauranteApp
{
    internal class Restaurante : Utilities
    {
        private static Restaurante instance = null;
        private string name = "Restaurant Name";
        public static Restaurante GetInstance()
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
            CleanConsola();
            new RestauranteVerMercaderias().ListarMercaderia();
        }

        public void HacerPedido()
        {
            CleanConsola();
            new RestauranteVerMercaderias().ListaMercaderiaSimplificada();
            new RestauranteHacerPedido().HacerUnPedido();
        }

        public void ConsultarPedido()
        {
            CleanConsola();
            new RestauranVerPedidos().ConsultarPedido();
        }

        public void VerPedidos()
        {
            CleanConsola();
            new RestauranVerPedidos().ListarPedidos();
        }


        private List<FormaEntrega> ConseguirFormasDeEntrega()
        {
            return new RestauranteFormasDeEntrega().FormaEntregas();
        }

    }
}
