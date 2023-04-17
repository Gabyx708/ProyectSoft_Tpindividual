using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface ITipoMercaderiaCommand
    {
        void InsertTipoMercaderia(TipoMercaderia NuevoTipoMercaderia);

        void RemoveTipoMercaderia(int IipoMercaderiaId);

        void UpdateTipoMercaderia(int TipoMercaderiaId);
    }
}
