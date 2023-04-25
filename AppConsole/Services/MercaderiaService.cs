using Application.Interfaces;
using Application.Models.Mercaderia;
using Application.Models.TipoMercaderia;
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
        private readonly ITipoMercaderiaService _serviceTipoMercaderia;


        public MercaderiaService(IMercaderiaCommand Command, IMercaderiaQuery Query, ITipoMercaderiaService serviceTipoMercaderia)
        {
            _command = Command;
            _query = Query;
            _serviceTipoMercaderia = serviceTipoMercaderia;
        }

        public Mercaderia CreateMercaderia(int MercaderiaId, string Nombre, int TipoMercaderiaId, string Ingredientes, string Preparacion, string Imagen,int Precio)
        {
            var Mercaderia = new Mercaderia
            {
                MercaderiaId =  MercaderiaId,
                Nombre = Nombre,
                TipoMercaderiaId = TipoMercaderiaId,
                Preparacion = Preparacion,
                Imagen = Imagen,
                Precio = Precio
            };

            _command.InsertMercaderia(Mercaderia);
            return Mercaderia;
        }

        public void DeleteMercaderia(int MercaderiaId)
        {
            _command.RemoveMercaderia(MercaderiaId);
        }

        public List<Mercaderia> GetAll()
        {
            return _query.GetListaMercaderia();
        }


        public MercaderiaGetResponse GetById(int MercaderiaId)
        {
            var mercaderia = _query.GetMercaderia(MercaderiaId);

            if (mercaderia != null)
            {
                return new MercaderiaGetResponse
                {
                    id = mercaderia.MercaderiaId,
                    nombre = mercaderia.Nombre,
                    precio = mercaderia.Precio,
                    tipo = _serviceTipoMercaderia.GetById(mercaderia.TipoMercaderiaId),
                    imagen = mercaderia.Imagen
                };
            }

            return null;
        }

        public void UpdateMercaderia(int MercaderiaId)
        {
            _command.UpdateMercaderia(MercaderiaId);
        }
    }
}
