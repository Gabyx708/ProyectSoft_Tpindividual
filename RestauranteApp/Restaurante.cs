using Domain.Entities;
using RestauranteApp.ResatauranteFunctions;

namespace RestauranteApp
{
    internal class Restaurante : Utilities
    {
        private static Restaurante instance = null;
        private string _name = "Restaurant Name";
        public static Restaurante GetInstance()
        {
            if (instance == null)
            {
                instance = new Restaurante();
            }
            return instance;
        }

        public string Name
        { get { return _name; } }

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
            new RestauranVerPedidos().ListarPedidos();
        }


        private List<FormaEntrega> ConseguirFormasDeEntrega()
        {
            return new RestauranteFormasDeEntrega().FormaEntregas();
        }

    }
}
