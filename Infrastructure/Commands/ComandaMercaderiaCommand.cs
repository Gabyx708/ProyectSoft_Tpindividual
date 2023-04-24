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
    public class ComandaMercaderiaCommand : IComandaMercaderiaCommand
    {
        private readonly AppDbcontext _context;

        public ComandaMercaderiaCommand(AppDbcontext context)
        {
            _context = context;
        }

        public void InsertComandaMercaderia(ComandaMercaderia NuevoComandaMercaderia)
        {
            _context.Add(NuevoComandaMercaderia);
            _context.SaveChanges();
        }

        public void RemoveComandaMercaderia(int ComandaMercaderiaId)
        {
            ComandaMercaderia ComandaMercaderiaEliminar = _context.ComandaMercaderias.Single(cm => cm.ComandaMercaderiaId == ComandaMercaderiaId);
            _context.Remove<ComandaMercaderia>(ComandaMercaderiaEliminar);
            _context.SaveChanges();
        }

        public void UpdateComandaMercaderia(int ComandaMercaderiaId)
        {
            ComandaMercaderia ComandaMercaderiaUpdate = _context.ComandaMercaderias.Single(cm => cm.ComandaMercaderiaId == ComandaMercaderiaId);
            _context.Update<ComandaMercaderia>(ComandaMercaderiaUpdate);
            _context.SaveChanges();
        }
    }
}
