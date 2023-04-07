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
        Mercaderia createMercaderia(int mercaderiaId,string nombre,int tipomercaderiaId,string ingredientes,string preparacion,string imagen,int precio);

        void updateMercaderia(int mercaderiaId);

        void deleteMercaderia(int mercaderiaId);

        List<Mercaderia> getAll();

        Mercaderia getById(int mercaderiaId);
    }
}
