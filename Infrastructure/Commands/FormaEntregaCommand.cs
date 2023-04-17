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
    public  class FormaEntregaCommand : IFormaEntregaCommand
    {
        private readonly AppDbcontext context;

        public FormaEntregaCommand()
        {
            context = AppDbcontext.GetInstance();
        }

        public  void InsertFormaEntrega(FormaEntrega FormaEntrega)
        {
            context.Add(FormaEntrega);
            context.SaveChanges();
        }

        public  void RemoveFormaEntrega(int FormaEntregaId)
        {
            FormaEntrega FormaEntregaEliminar = context.FormaEntregas.Single(fe => fe.FormaEntregaId == FormaEntregaId);
            context.Remove<FormaEntrega>(FormaEntregaEliminar);
            context.SaveChanges();
        }

        public void UpdateFormaEntrega(int FormaEntregaId)
        {
            FormaEntrega FormaEntregaUpdate = context.FormaEntregas.Single(fe => fe.FormaEntregaId == FormaEntregaId);
            context.Update<FormaEntrega>(FormaEntregaUpdate);
            context.SaveChanges();
        }
    }
}
