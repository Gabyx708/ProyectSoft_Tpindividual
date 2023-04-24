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
    public class MercaderiaCommand : IMercaderiaCommand
    {
        private readonly AppDbcontext _context;

        public MercaderiaCommand(AppDbcontext context)
        {
            _context = context;
        }

        public void InsertMercaderia(Mercaderia NuevaMercaderia)
        {
            _context.Add(NuevaMercaderia);
            _context.SaveChanges();
        }

        public void RemoveMercaderia(int MercaderiaId)
        {
            Mercaderia MercaderiaEliminar = _context.Mercaderias.Single(m => m.MercaderiaId == MercaderiaId);
            _context.Remove<Mercaderia>(MercaderiaEliminar);
            _context.SaveChanges();
        }

        public void UpdateMercaderia(int MercaderiaId)
        {
            Mercaderia MercaderiaUpdate = _context.Mercaderias.Single(m => m.MercaderiaId == MercaderiaId);
            _context.Update<Mercaderia>(MercaderiaUpdate);
            _context.SaveChanges();
        }
    }
}
