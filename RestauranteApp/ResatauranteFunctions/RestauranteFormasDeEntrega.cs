using Application.Interfaces;
using Application.Services;
using Domain.Entities;
using Infrastructure.Commands;
using Infrastructure.Querys;

namespace RestauranteApp.ResatauranteFunctions
{
    public class RestauranteFormasDeEntrega
    {
        private readonly IFormaEntregaService _service;

        public RestauranteFormasDeEntrega()
        {
            _service = new FormaEntregaServices(new FormaEntregaCommand(), new FormaEntregaQuery()); ;
        }

        public List<FormaEntrega> FormaEntregas()
        {
            return _service.GetAll();
        }

        public FormaEntrega UsarFormaEntrega(int Id)
        {
            return _service.GetById(Id);
        }
    }
}
