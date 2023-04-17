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
        private readonly AppDbcontext context;

        public ComandaMercaderiaCommand()
        {
            context = AppDbcontext.getInstance();
        }

        public void InsertComandaMercaderia(ComandaMercaderia NuevoComandaMercaderia)
        {
            context.Add(NuevoComandaMercaderia);
            context.SaveChanges();
        }

        public void RemoveComandaMercaderia(int ComandaMercaderiaId)
        {
            ComandaMercaderia ComandaMercaderiaEliminar = context.comandaMercaderias.Single(cm => cm.ComandaMercaderiaId == ComandaMercaderiaId);
            context.Remove<ComandaMercaderia>(ComandaMercaderiaEliminar);
            context.SaveChanges();
        }

        public void UpdateComandaMercaderia(int ComandaMercaderiaId)
        {
            ComandaMercaderia ComandaMercaderiaUpdate = context.comandaMercaderias.Single(cm => cm.ComandaMercaderiaId == ComandaMercaderiaId);
            context.Update<ComandaMercaderia>(ComandaMercaderiaUpdate);
            context.SaveChanges();
        }
    }
}
