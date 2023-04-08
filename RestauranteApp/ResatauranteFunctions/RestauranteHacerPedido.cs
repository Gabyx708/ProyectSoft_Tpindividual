using Application.Interfaces;
using Application.Services;
using Domain.Entities;
using Infrastructure.Commands;
using Infrastructure.Querys;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestauranteApp.ResatauranteFunctions
{
    public class RestauranteHacerPedido
    {
        private IComandaService service = new ComandaService(new ComandaCommand(),new ComandaQuery());
        private IComandaMercaderiaService serviceComandaMercaderia = new ComandaMercaderiaService(new ComandaMercaderiaCommand(),new ComandaMercaderiaQuery());

        public void crearPedido(List<Mercaderia>platillos,FormaEntrega formaDeEntrega)
        {
            int precioTotal = 0;
            DateTime fecha = new DateTime();

            foreach (Mercaderia mercaderia in platillos)
            {
                precioTotal = mercaderia.Precio + precioTotal;
            }

            Comanda nuevaComanda = service.createComanda(formaDeEntrega,precioTotal,fecha);

            foreach (Mercaderia mercaderia in platillos)
            {
                serviceComandaMercaderia.createComandaMercaderia(mercaderia.MercaderiaId, nuevaComanda.ComandaId);
            }
            
        }
    }
}
