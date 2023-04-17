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
            context = AppDbcontext.GetInstance();
        }

        public List<TipoMercaderia> GetListaTipoMercaderia()
        {
            return context.TipoMercaderias.ToList<TipoMercaderia>();
        }

        public TipoMercaderia GetTipoMercaderia(int TipoMercaderiaId)
        {
            var TipoMercaderiaEncontrada = context.Find<TipoMercaderia>(TipoMercaderiaId);
            if (TipoMercaderiaEncontrada != null)
            {
                return TipoMercaderiaEncontrada;
            }
            return null;
        }
    }
}
