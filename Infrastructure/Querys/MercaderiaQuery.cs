using Application.Interfaces;
using Domain.Entities;
using Infrastructure.Persistence;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Querys
{
    public class MercaderiaQuery : IMercaderiaQuery
    {
        private readonly AppDbcontext _context;

        public MercaderiaQuery(AppDbcontext context)
        {
            _context = context;
        }

        public List<Mercaderia> GetListaMercaderia()
        {
            return _context.Mercaderias.ToList<Mercaderia>();
        }

        public Mercaderia GetMercaderia(int MercaderiaId)
        {
            var MercaderiaEncontrada = _context.Mercaderias.Find(MercaderiaId);
            if (MercaderiaEncontrada != null)
            {
                return MercaderiaEncontrada;
            }
            return null;
        }
    }
}
