using Domain.Entities;
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
            new RestauranteVerMercaderias().ListarMercaderia();
        }

        public void HacerPedido()
        {
            new RestauranteVerMercaderias().ListaMercaderiaSimplificada();
            new RestauranteHacerPedido().hacerUnPedido();
        }

        public void ConsultarPedido()
        {
            new RestauranVerPedidos().ConsultarPedido();
        }

        public void VerPedidos()
        {
            new RestauranVerPedidos().ListarPedidos();
        }


        private List<FormaEntrega> ConseguirFormasDeEntrega()
        {
            return new RestauranteFormasDeEntrega().FormaEntregas();
        }

    }
}
