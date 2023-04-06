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
            context = AppDbcontext.getInstance();
        }

        public  void InsertFormaEntrega(FormaEntrega formaEntrega)
        {
            context.Add(formaEntrega);
            context.SaveChanges();
        }

        public  void RemoveFormaEntrega(int formaEntregaid)
        {
            FormaEntrega FormaEntregaEliminar = context.FormaEntregas.Single(fe => fe.FormaEntregaId == formaEntregaid);
            context.Remove<FormaEntrega>(FormaEntregaEliminar);
            context.SaveChanges();
        }
    }
}
