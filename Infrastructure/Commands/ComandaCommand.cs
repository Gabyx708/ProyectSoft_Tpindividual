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
    public class ComandaCommand : IComandaCommand
    {
        private readonly AppDbcontext _context;

        public ComandaCommand(AppDbcontext context)
        {
            _context = context;
        }

        public void InsertComanda(Comanda NuevaComanda)
        {
            _context.Add(NuevaComanda);
            _context.SaveChanges();
        }

        public void RemoveComanda(int ComandaId)
        {
            Comanda ComandaaEliminar = _context.Comandas.Single(c => c.ComandaId.Equals(ComandaId));
            _context.Remove<Comanda>(ComandaaEliminar);
            _context.SaveChanges();
        }

        public void UpdateComanda(int ComandaId)
        {
            Comanda ComandaaEditar = _context.Comandas.Single(c => c.ComandaId.Equals(ComandaId));
            _context.Update(ComandaaEditar);
            _context.SaveChanges();
        }
    }
}
