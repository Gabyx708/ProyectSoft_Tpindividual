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
        private readonly AppDbcontext context;

        public MercaderiaQuery()
        {
            context = AppDbcontext.getInstance();
        }

        public List<Mercaderia> GetListaMercaderia()
        {
            return context.Mercaderias.ToList<Mercaderia>();
        }

        public Mercaderia GetMercaderia(int mercaderiaId)
        {
            var MercaderiaEncontrada = context.Find<Mercaderia>(mercaderiaId);
            if (MercaderiaEncontrada != null)
            {
                return MercaderiaEncontrada;
            }
            return null;
        }
    }
}
