using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface ITipoMercaderiaService
    {
        TipoMercaderia CreateTipoMercaderia(int TipoMercaderiaid, string Descripcion);

        void UpdateTipoMercaderia(int TipomercaderiaId);

        void DeleteTipoMercaderia(int TipomercaderiaId);

        List<TipoMercaderia> GetAll();

        TipoMercaderia GetById(int TipomercaderiaId);
    }
}
