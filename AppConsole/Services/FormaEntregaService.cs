using Application.Interfaces;
using Application.Models.FormaEntrega;
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

        public FormaEntregaServices(IFormaEntregaCommand Command, IFormaEntregaQuery Query)
        {
            _command = Command;
            _query = Query;
        }

        public FormaEntrega CreateFormaEntrega(string Descripcion)
        {
            var FormaEntrega = new FormaEntrega
            {
                Descripcion = Descripcion
            };


            _command.InsertFormaEntrega(FormaEntrega);
            return FormaEntrega;
        }

        public void DeleteFormaEntrega(int FormaEntregaId)
        {
            _command.RemoveFormaEntrega(FormaEntregaId);
        }

        public List<FormaEntrega> GetAll()
        {
            return _query.GetListFormaEntrega();
        }

        public FormaEntrega_ GetById(int FormaEntregaId)
        {
            var formaEntrega= _query.GetFormaEntrega(FormaEntregaId);

            if (formaEntrega != null)
            {
                return new FormaEntrega_
                {
                    id = formaEntrega.FormaEntregaId,
                    descripcion = formaEntrega.Descripcion
                };
            }

            return null;
        }

        public void UpdateFormaEntrega(int FormaEntregaId)
        {
             _command.UpdateFormaEntrega(FormaEntregaId);
        }
    }
}
