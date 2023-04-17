using Application.Interfaces;
using Domain.Entities;
using Infrastructure.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Querys
{
    public class ComandaQuery : IComandaQuery
    {
        private readonly AppDbcontext context;
        public ComandaQuery()
        {
            context = AppDbcontext.GetInstance();
        }

        public Comanda GetComanda(Guid ComandaId)
        {
            var ComandaEncontrada = context.Find<Comanda>(ComandaId);
            if (ComandaEncontrada != null)
            {
                return ComandaEncontrada;
            }
            return null;
        }

        public List<Comanda> GetListaComanda()
        {
            return context.Comandas.ToList<Comanda>();
        }
    }
}
