using Application.Interfaces;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public class ComandaService : IComandaService
    {
        private readonly IComandaCommand _command;
        private readonly IComandaQuery _query;

        public ComandaService(IComandaCommand command, IComandaQuery query)
        {
            _command = command;
            _query = query;
        }

        public Comanda createComanda(FormaEntrega comandaFormaEntrega, int precioTotal, DateTime Fecha)
        {
            var comanda = new Comanda
            {
                PrecioTotal = precioTotal,
                Fecha = Fecha,
                FormaEntrega = comandaFormaEntrega,
                FormaEntregaId = comandaFormaEntrega.FormaEntregaId
            };

            _command.insertComanda(comanda);
            return comanda;
        }

        public void deleteComanda(int comandaId)
        {
            _command.removeComanda(comandaId);
        }

        public List<Comanda> getAll()
        {
            return _query.GetListaComanda();
        }

        public Comanda getByid(int comandaId)
        {
            return _query.GetComanda(comandaId);
        }

        public void updateComanda(int comandaId)
        {
            _command.updateComanda(comandaId);
        }
    }
}
