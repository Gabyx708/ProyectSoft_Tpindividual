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
    public  class FormaEntregaCommand : IFormaEntregaCommand
    {
        private readonly AppDbcontext _context;

        public FormaEntregaCommand(AppDbcontext context)
        {
            _context = context;
        }

        public  void InsertFormaEntrega(FormaEntrega FormaEntrega)
        {
            _context.Add(FormaEntrega);
            _context.SaveChanges();
        }

        public  void RemoveFormaEntrega(int FormaEntregaId)
        {
            FormaEntrega FormaEntregaEliminar = _context.FormaEntregas.Single(fe => fe.FormaEntregaId == FormaEntregaId);
            _context.Remove<FormaEntrega>(FormaEntregaEliminar);
            _context.SaveChanges();
        }

        public void UpdateFormaEntrega(int FormaEntregaId)
        {
            FormaEntrega FormaEntregaUpdate = _context.FormaEntregas.Single(fe => fe.FormaEntregaId == FormaEntregaId);
            _context.Update<FormaEntrega>(FormaEntregaUpdate);
            _context.SaveChanges();
        }
    }
}
