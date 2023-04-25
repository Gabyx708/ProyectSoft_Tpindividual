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
    public class FormaEntregaQuery : IFormaEntregaQuery
    {
        private readonly AppDbcontext _context;

        public FormaEntregaQuery(AppDbcontext context)
        {
            _context = context;
        }

        public FormaEntrega GetFormaEntrega(int FormaEntregaId)
        {
            var formaEntrega = _context.FormaEntregas.FirstOrDefault(fe => fe.FormaEntregaId == FormaEntregaId);
            return formaEntrega;
        }

        public List<FormaEntrega> GetListFormaEntrega()
        {
           return _context.FormaEntregas.ToList<FormaEntrega>();
        }
    }
}
