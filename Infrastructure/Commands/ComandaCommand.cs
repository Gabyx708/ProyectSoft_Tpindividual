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
        public void insertComanda(Comanda nuevaComanda)
        {
            context.Add(nuevaComanda);
            context.SaveChanges();
        }

        public void removeComanda(int comandaId)
        {
            Comanda ComandaaEliminar = context.Comandas.Single(c => c.ComandaId.Equals(comandaId));
            context.Remove<Comanda>(ComandaaEliminar);
            context.SaveChanges();
        }

        public void updateComanda(int comandaId)
        {
            Comanda ComandaaEditar = context.Comandas.Single(c => c.ComandaId.Equals(comandaId));
            context.Update(ComandaaEditar);
            context.SaveChanges();
        }
    }
}
