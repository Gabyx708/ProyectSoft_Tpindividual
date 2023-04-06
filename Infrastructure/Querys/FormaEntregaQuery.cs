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
    public class FormaEntregaQuery : IFormaEntregaQuery
    {
        private readonly AppDbcontext context;

        public FormaEntregaQuery()
        {
            context = AppDbcontext.getInstance();
        }

        public FormaEntrega GetFormaEntrega(int Formaentregaid)
        {
           var FormaEntregaEncontrada = context.Find<FormaEntrega>(Formaentregaid);
            if(FormaEntregaEncontrada != null)
            {
                return FormaEntregaEncontrada;
            }
            return null;
        }

        public List<FormaEntrega> GetListFormaEntrega()
        {
           return context.FormaEntregas.ToList<FormaEntrega>();
        }
    }
}
