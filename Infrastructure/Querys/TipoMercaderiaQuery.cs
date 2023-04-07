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
        public readonly AppDbcontext context;

        public TipoMercaderiaQuery()
        {
            context = AppDbcontext.getInstance();
        }

        public List<TipoMercaderia> GetListaTipoMercaderia()
        {
            return context.TipoMercaderias.ToList<TipoMercaderia>();
        }

        public TipoMercaderia GetTipoMercaderia(int tipomercaderiaid)
        {
            var tipoMercaderiaEncontrada = context.Find<TipoMercaderia>(tipomercaderiaid);
            if (tipoMercaderiaEncontrada != null)
            {
                return tipoMercaderiaEncontrada;
            }
            return null;
        }
    }
}
