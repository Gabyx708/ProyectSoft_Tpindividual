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

        public TipoMercaderia CreateTipoMercaderia(int TipoMercaderiaId,string Descripcion)
        {
            var TipoMercaderia = new TipoMercaderia
            {
                TipoMercaderiaId = TipoMercaderiaId,
                Descripcion = Descripcion
            };

            _command.InsertTipoMercaderia(TipoMercaderia);
            return TipoMercaderia;
        }

        public void DeleteTipoMercaderia(int TipoMercaderiaId)
        {
            _command.RemoveTipoMercaderia(TipoMercaderiaId);
        }

        public List<TipoMercaderia> GetAll()
        {
            return _query.GetListaTipoMercaderia();
        }

        public TipoMercaderia GetById(int TipoMercaderiaId)
        {
            return _query.GetTipoMercaderia(TipoMercaderiaId);
        }

        public void UpdateTipoMercaderia(int TipoMercaderiaId)
        {
            _command.UpdateTipoMercaderia(TipoMercaderiaId);
        }
    }
}
