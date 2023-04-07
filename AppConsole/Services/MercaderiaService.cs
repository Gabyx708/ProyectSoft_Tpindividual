using Application.Interfaces;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public class MercaderiaService : IMercaderiaService
    {
        private readonly IMercaderiaCommand _command;
        private readonly IMercaderiaQuery _query;

        public MercaderiaService(IMercaderiaCommand command, IMercaderiaQuery query)
        {
            _command = command;
            _query = query;
        }

        public Mercaderia createMercaderia(int mercaderiaId, string nombre, int tipomercaderiaId, string ingredientes, string preparacion, string imagen,int precio)
        {
            var mercaderia = new Mercaderia
            {
                MercaderiaId = mercaderiaId,
                Nombre = nombre,
                TipoMercaderiaId = tipomercaderiaId,
                Preparacion = preparacion,
                Imagen = imagen,
                Precio = precio
            };

            _command.insertMercaderia(mercaderia);
            return mercaderia;
        }

        public void deleteMercaderia(int mercaderiaId)
        {
            _command.removeMercaderia(mercaderiaId);
        }

        public List<Mercaderia> getAll()
        {
            return _query.GetListaMercaderia();
        }

        public Mercaderia getById(int mercaderiaId)
        {
            return _query.GetMercaderia(mercaderiaId);
        }

        public void updateMercaderia(int mercaderiaId)
        {
            _command.updateMercaderia(mercaderiaId);
        }
    }
}
