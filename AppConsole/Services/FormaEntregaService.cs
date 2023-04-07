using Application.Interfaces;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
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

        public FormaEntrega createFormaentrega(string Descripcion)
        {
            var formaEntrega = new FormaEntrega
            {
                Descripcion = Descripcion
            };


            _command.InsertFormaEntrega(formaEntrega);
            return formaEntrega;
        }

        public void deleteFormaentrega(int FormaEntregaid)
        {
            _command.RemoveFormaEntrega(FormaEntregaid);
        }

        public List<FormaEntrega> getAll()
        {
            return _query.GetListFormaEntrega();
        }

        public FormaEntrega getByid(int FormaEntregaid)
        {
            return _query.GetFormaEntrega(FormaEntregaid);
        }

        public void UpdateFormaentrega(int FormaEntregaid)
        {
             _command.UpdateFormaEntrega(FormaEntregaid);
        }
    }
}
