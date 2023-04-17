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
            context = AppDbcontext.getInstance();  
        }

        public void InsertTipoMercaderia(TipoMercaderia nuevoTipoMercaderia)
        {
            context.Add(nuevoTipoMercaderia);
            context.SaveChanges();
        }

        public void RemoveTipoMercaderia(int tipoMercaderiaId)
        {
            TipoMercaderia tipoMercaderiaEliminar = context.TipoMercaderias.Single(tm => tm.TipoMercaderiaId == tipoMercaderiaId);
            context.Remove<TipoMercaderia>(tipoMercaderiaEliminar);
            context.SaveChanges();
        }

        public void UpdateTipoMercaderia(int tipoMercaderiaId)
        {
            TipoMercaderia tipoMercaderiaEliminar = context.TipoMercaderias.Single(tm => tm.TipoMercaderiaId == tipoMercaderiaId);
            context.Update<TipoMercaderia>(tipoMercaderiaEliminar);
            context.SaveChanges();
        }
    }
}
