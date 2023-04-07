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

        public void insertComandaMercaderia(ComandaMercaderia nuevoComandaMercaderia)
        {
            context.Add(nuevoComandaMercaderia);
            context.SaveChanges();
        }

        public void removeComandaMercaderia(int comandaMercaderiaId)
        {
            ComandaMercaderia comandaMercaderiaEliminar = context.comandaMercaderias.Single(cm => cm.ComandaMercaderiaId == comandaMercaderiaId);
            context.Remove<ComandaMercaderia>(comandaMercaderiaEliminar);
            context.SaveChanges();
        }

        public void updateComandaMercaderia(int comandaMercaderiaId)
        {
            ComandaMercaderia comandaMercaderiaUpdate = context.comandaMercaderias.Single(cm => cm.ComandaMercaderiaId == comandaMercaderiaId);
            context.Update<ComandaMercaderia>(comandaMercaderiaUpdate);
            context.SaveChanges();
        }
    }
}
