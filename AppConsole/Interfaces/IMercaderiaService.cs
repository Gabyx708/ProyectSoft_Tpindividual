using Application.Models.Mercaderia;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IMercaderiaService
    {
        Mercaderia CreateMercaderia(int MercaderiaId,string Nombre,int TipoMercaderiaId,string Ingredientes,string Preparacion,string Imagen,int Precio);

        void UpdateMercaderia(int MercaderiaId);

        void DeleteMercaderia(int MercaderiaId);

        List<Mercaderia> GetAll();

        MercaderiaGetResponse GetById(int MercaderiaId);
    }
}
