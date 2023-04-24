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
        private readonly AppDbcontext _context;

        public TipoMercaderiaCommand(AppDbcontext context)
        {
            _context = context;
        }

        public void InsertTipoMercaderia(TipoMercaderia NuevoTipoMercaderia)
        {
            _context.Add(NuevoTipoMercaderia);
            _context.SaveChanges();
        }

        public void RemoveTipoMercaderia(int TipoMercaderiaId)
        {
            TipoMercaderia tipoMercaderiaEliminar = _context.TipoMercaderias.Single(tm => tm.TipoMercaderiaId == TipoMercaderiaId);
            _context.Remove<TipoMercaderia>(tipoMercaderiaEliminar);
            _context.SaveChanges();
        }

        public void UpdateTipoMercaderia(int TipoMercaderiaId)
        {
            TipoMercaderia TipoMercaderiaEliminar = _context.TipoMercaderias.Single(tm => tm.TipoMercaderiaId == TipoMercaderiaId);
            _context.Update<TipoMercaderia>(TipoMercaderiaEliminar);
            _context.SaveChanges();
        }
    }
}
