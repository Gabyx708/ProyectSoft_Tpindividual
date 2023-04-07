using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IComandaMercaderiaService
    {
        ComandaMercaderia createComandaMercaderia(int MercaderiaId, Guid ComandaId);

        void updateComandaMercaderia(int comandaMercaderiaId);

        void delteComandaMercaderia(int comandaMercaderiaId);

        List<ComandaMercaderia> getAll();

        ComandaMercaderia getByid(int comandaMercaderiaId);
    }
}
