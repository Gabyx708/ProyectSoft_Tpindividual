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

        public ComandaService(IComandaCommand Command, IComandaQuery Query)
        {
            _command = Command;
            _query = Query;
        }

        public Comanda CreateComanda(FormaEntrega ComandaFormaEntrega, int PrecioTotal, DateTime Fecha)
        {
            var Comanda = new Comanda
            {
                PrecioTotal = PrecioTotal,
                Fecha = Fecha,
                FormaEntrega = ComandaFormaEntrega,
                FormaEntregaId = ComandaFormaEntrega.FormaEntregaId
            };

            _command.InsertComanda(Comanda);
            return Comanda;
        }

        public void DeleteComanda(int ComandaId)
        {
            _command.RemoveComanda(ComandaId);
        }

        public List<Comanda> GetAll()
        {
            return _query.GetListaComanda();
        }

        public Comanda GetById(Guid ComandaId)
        {
            return _query.GetComanda(ComandaId);
        }

        public void UpdateComanda(int ComandaId)
        {
            _command.UpdateComanda(ComandaId);
        }
    }
}
