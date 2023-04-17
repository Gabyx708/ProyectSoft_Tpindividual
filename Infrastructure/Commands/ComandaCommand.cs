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
    public class ComandaCommand : IComandaCommand
    {
        private readonly AppDbcontext context;
        
        public ComandaCommand()
        {
            context = AppDbcontext.getInstance();
        }
        public void InsertComanda(Comanda NuevaComanda)
        {
            context.Add(NuevaComanda);
            context.SaveChanges();
        }

        public void RemoveComanda(int ComandaId)
        {
            Comanda ComandaaEliminar = context.Comandas.Single(c => c.ComandaId.Equals(ComandaId));
            context.Remove<Comanda>(ComandaaEliminar);
            context.SaveChanges();
        }

        public void UpdateComanda(int ComandaId)
        {
            Comanda ComandaaEditar = context.Comandas.Single(c => c.ComandaId.Equals(ComandaId));
            context.Update(ComandaaEditar);
            context.SaveChanges();
        }
    }
}
