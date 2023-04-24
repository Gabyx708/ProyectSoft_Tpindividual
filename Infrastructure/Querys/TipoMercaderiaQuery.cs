using Application.Interfaces;
using Domain.Entities;
using Infrastructure.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Querys
{
    public class TipoMercaderiaQuery : ITipoMercaderiaQuery
    {
        public readonly AppDbcontext _context;

        
        public TipoMercaderiaQuery(AppDbcontext context)
        {
            _context = context;
        }

        public List<TipoMercaderia> GetListaTipoMercaderia()
        {
            return _context.TipoMercaderias.ToList<TipoMercaderia>();
        }

        public TipoMercaderia GetTipoMercaderia(int TipoMercaderiaId)
        {
            var TipoMercaderiaEncontrada = _context.Find<TipoMercaderia>(TipoMercaderiaId);
            if (TipoMercaderiaEncontrada != null)
            {
                return TipoMercaderiaEncontrada;
            }
            return null;
        }
    }
}
