using Application.Interfaces;
using Domain.Entities;
using Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Querys
{
    public class ComandaMercaderiaQuery : IComandaMercaderiaQuery
    {
        private readonly AppDbcontext _context;

        public ComandaMercaderiaQuery(AppDbcontext context)
        {
            _context = context;
        }

        public ComandaMercaderia GetComanda(int ComandaMercaderiaId)
        {
            var ComandaMercaderiaEncontrada = _context.Find<ComandaMercaderia>(ComandaMercaderiaId);
            if (ComandaMercaderiaEncontrada != null)
            {
                return ComandaMercaderiaEncontrada;
            }
            return null;
        }

        public List<ComandaMercaderia> GetListaComandaMercaderia()
        {
            return _context.ComandaMercaderias.ToList<ComandaMercaderia>();
        }

        public List<ComandaMercaderia> GetListaComandaMercaderiaByComandaId(Guid ComandaId)
        {
            return _context.ComandaMercaderias.Where(cm => cm.ComandaId.Equals(ComandaId)).ToList();
        }
    }
}
