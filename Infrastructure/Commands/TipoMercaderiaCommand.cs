using Application.Interfaces;
using Domain.Entities;
using Infrastructure.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Commands
{
    public class TipoMercaderiaCommand : ITipoMercaderiaCommand
    {
        private readonly AppDbcontext context;

        public TipoMercaderiaCommand()
        {
            context = AppDbcontext.GetInstance();  
        }

        public void InsertTipoMercaderia(TipoMercaderia NuevoTipoMercaderia)
        {
            context.Add(NuevoTipoMercaderia);
            context.SaveChanges();
        }

        public void RemoveTipoMercaderia(int TipoMercaderiaId)
        {
            TipoMercaderia tipoMercaderiaEliminar = context.TipoMercaderias.Single(tm => tm.TipoMercaderiaId == TipoMercaderiaId);
            context.Remove<TipoMercaderia>(tipoMercaderiaEliminar);
            context.SaveChanges();
        }

        public void UpdateTipoMercaderia(int TipoMercaderiaId)
        {
            TipoMercaderia TipoMercaderiaEliminar = context.TipoMercaderias.Single(tm => tm.TipoMercaderiaId == TipoMercaderiaId);
            context.Update<TipoMercaderia>(TipoMercaderiaEliminar);
            context.SaveChanges();
        }
    }
}
