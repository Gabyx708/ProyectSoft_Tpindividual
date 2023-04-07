using Application.Interfaces;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public class TipoMercaderiaService : ITipoMercaderiaService
    {
        private readonly ITipoMercaderiaCommand _command;
        private readonly ITipoMercaderiaQuery _query;

        public TipoMercaderiaService(ITipoMercaderiaCommand command, ITipoMercaderiaQuery query)
        {
            _command = command;
            _query = query;
        }

        public TipoMercaderia createTipoMercaderia(int tipomercaderiaId,string Descripcion)
        {
            var tipoMercaderia = new TipoMercaderia
            {
                TipoMercaderiaId = tipomercaderiaId,
                Descripcion = Descripcion
            };

            _command.insertTipoMercaderia(tipoMercaderia);
            return tipoMercaderia;
        }

        public void delteTipoMercaderia(int tipomercaderiaId)
        {
            _command.removeTipoMercaderia(tipomercaderiaId);
        }

        public List<TipoMercaderia> getAll()
        {
            return _query.GetListaTipoMercaderia();
        }

        public TipoMercaderia getByid(int tipomercaderiaId)
        {
            return _query.GetTipoMercaderia(tipomercaderiaId);
        }

        public void updateTipoMercaderia(int tipomercaderiaId)
        {
            _command.updateTipoMercaderia(tipomercaderiaId);
        }
    }
}
