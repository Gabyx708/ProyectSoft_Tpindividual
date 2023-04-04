using Application.Interfaces;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application
{
    public class FormaEntregaServices : IFormaEntregaService
    {
        private readonly IFormaEntregaCommand _command;
        private readonly IFormaEntregaQuery _query;

        public FormaEntregaServices(IFormaEntregaCommand command, IFormaEntregaQuery query)
        {
            _command = command;
            _query = query;
        }

        public  async Task<FormaEntrega> createFormaentrega(string Descripcion)
        {
            var formaEntrega = new FormaEntrega
            {
                Descripcion = Descripcion
            };


            await _command.InsertFormaEntrega(formaEntrega);
            return formaEntrega;
        }

        public Task<FormaEntrega> deleteFormaentrega(int FormaEntregaid)
        {
            throw new NotImplementedException();
        }

        public Task<List<FormaEntrega>> getAll()
        {
            throw new NotImplementedException();
        }

        public Task<FormaEntrega> getByid(int FormaEntregaid)
        {
            throw new NotImplementedException();
        }

        public Task<FormaEntrega> UpdateFormaentrega(int FormaEntregaid)
        {
            throw new NotImplementedException();
        }
    }
}
