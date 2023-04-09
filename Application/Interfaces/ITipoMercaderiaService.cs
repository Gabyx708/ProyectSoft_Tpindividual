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
        TipoMercaderia createTipoMercaderia(int tipoMercaderiaid, string Descripcion);

        void updateTipoMercaderia(int tipomercaderiaId);

        void delteTipoMercaderia(int tipomercaderiaId);

        List<TipoMercaderia> getAll();

        TipoMercaderia getByid(int tipomercaderiaId);
    }
}
