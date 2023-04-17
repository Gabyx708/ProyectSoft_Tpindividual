using Application.Interfaces;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public class ComandaMercaderiaService : IComandaMercaderiaService
    {
        private readonly IComandaMercaderiaCommand _command;
        private readonly IComandaMercaderiaQuery _query;

        public ComandaMercaderiaService(IComandaMercaderiaCommand Command, IComandaMercaderiaQuery Query)
        {
            _command = Command;
            _query = Query;
        }

        public ComandaMercaderia CreateComandaMercaderia(int MercaderiaId, Guid ComandaId)
        {
            var ComandaMercaderia = new ComandaMercaderia
            {
                MercaderiaId = MercaderiaId,
                ComandaId = ComandaId
       
            };

            _command.InsertComandaMercaderia(ComandaMercaderia);
            return ComandaMercaderia;
        }

        public void DeleteComandaMercaderia(int ComandaMercaderiaId)
        {
            _command.RemoveComandaMercaderia(ComandaMercaderiaId);
        }

        public List<ComandaMercaderia> GetAll()
        {
            return _query.GetListaComandaMercaderia();
        }

        public List<ComandaMercaderia> GetByComandaId(Guid ComandaId)
        {
            return _query.GetListaComandaMercaderiaByComandaId(ComandaId);
        }

        public ComandaMercaderia GetById(int ComandaMercaderiaId)
        {
            return _query.GetComanda(ComandaMercaderiaId);
        }

        public void UpdateComandaMercaderia(int ComandaMercaderiaId)
        {
            _command.UpdateComandaMercaderia(ComandaMercaderiaId);
        }
    }
}
