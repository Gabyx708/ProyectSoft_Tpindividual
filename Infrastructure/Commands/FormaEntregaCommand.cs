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

        public async Task InsertFormaEntrega(FormaEntrega formaEntrega)
        {
           context.Add(formaEntrega);
           await context.SaveChangesAsync();
        }

        public async Task RemoveFormaEntrega(int formaEntregaid)
        {
            context.Add(formaEntregaid);

            await context.SaveChangesAsync();
        }
    }
}
