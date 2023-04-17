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
        private readonly AppDbcontext context;

        public MercaderiaCommand()
        {
            context = AppDbcontext.GetInstance();
        }

        public void InsertMercaderia(Mercaderia NuevaMercaderia)
        {
            context.Add(NuevaMercaderia);
            context.SaveChanges();
        }

        public void RemoveMercaderia(int MercaderiaId)
        {
            Mercaderia MercaderiaEliminar = context.Mercaderias.Single(m => m.MercaderiaId == MercaderiaId);
            context.Remove<Mercaderia>(MercaderiaEliminar);
            context.SaveChanges();
        }

        public void UpdateMercaderia(int MercaderiaId)
        {
            Mercaderia MercaderiaUpdate = context.Mercaderias.Single(m => m.MercaderiaId == MercaderiaId);
            context.Update<Mercaderia>(MercaderiaUpdate);
            context.SaveChanges();
        }
    }
}
