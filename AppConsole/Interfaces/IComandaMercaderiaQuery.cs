using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IComandaMercaderiaQuery
    {
        List<ComandaMercaderia> GetListaComandaMercaderia();

        ComandaMercaderia GetComanda(int comandaMercaderia);

        List<ComandaMercaderia> GetListaComandaMercaderiaBycomandaId(Guid comandaId);
    }
}
