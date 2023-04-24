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
    public class ComandaQuery : IComandaQuery
    {
        private readonly AppDbcontext _context;

        public ComandaQuery(AppDbcontext context)
        {
            _context = context;
        }

        public Comanda GetComanda(Guid ComandaId)
        {
            var ComandaEncontrada = _context.Find<Comanda>(ComandaId);
            if (ComandaEncontrada != null)
            {
                return ComandaEncontrada;
            }
            return null;
        }

        public List<Comanda> GetListaComanda()
        {
            return _context.Comandas.ToList<Comanda>();
        }

        public List<Comanda> GetByDate(DateTime date)
        {
            return _context.Comandas.Where(c => c.Fecha.Day == date.Day && c.Fecha.Month == date.Month && c.Fecha.Year == date.Year ).ToList();
        }
    }
}
