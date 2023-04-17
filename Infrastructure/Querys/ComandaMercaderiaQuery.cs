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
        private readonly AppDbcontext context;

        public ComandaMercaderiaQuery()
        {
            context = AppDbcontext.GetInstance();
        }

        public ComandaMercaderia GetComanda(int ComandaMercaderiaId)
        {
            var ComandaMercaderiaEncontrada = context.Find<ComandaMercaderia>(ComandaMercaderiaId);
            if (ComandaMercaderiaEncontrada != null)
            {
                return ComandaMercaderiaEncontrada;
            }
            return null;
        }

        public List<ComandaMercaderia> GetListaComandaMercaderia()
        {
            return context.ComandaMercaderias.ToList<ComandaMercaderia>();
        }

        public List<ComandaMercaderia> GetListaComandaMercaderiaByComandaId(Guid ComandaId)
        {
            return context.ComandaMercaderias.Where(cm => cm.ComandaId.Equals(ComandaId)).ToList();
        }
    }
}
