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

        public ComandaMercaderiaService(IComandaMercaderiaCommand command, IComandaMercaderiaQuery query)
        {
            _command = command;
            _query = query;
        }

        public ComandaMercaderia createComandaMercaderia(int ComandaMercaderiaId, Guid ComandaId)
        {
            var comandaMercaderia = new ComandaMercaderia
            {
                ComandaMercaderiaId = ComandaMercaderiaId,
                ComandaId = ComandaId
            };

            _command.insertComandaMercaderia(comandaMercaderia);
            return comandaMercaderia;
        }

        public void delteComandaMercaderia(int comandaMercaderiaId)
        {
            _command.removeComandaMercaderia(comandaMercaderiaId);
        }

        public List<ComandaMercaderia> getAll()
        {
            return _query.GetListaComandaMercaderia();
        }

        public ComandaMercaderia getByid(int comandaMercaderiaId)
        {
            return _query.GetComanda(comandaMercaderiaId);
        }

        public void updateComandaMercaderia(int comandaMercaderiaId)
        {
            _command.updateComandaMercaderia(comandaMercaderiaId);
        }
    }
}
