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
        ComandaMercaderia CreateComandaMercaderia(int MercaderiaId, Guid ComandaId);

        void UpdateComandaMercaderia(int ComandaMercaderiaId);

        void DeleteComandaMercaderia(int ComandaMercaderiaId);

        List<ComandaMercaderia> GetAll();

        ComandaMercaderia GetById(int ComandaMercaderiaId);

        List<ComandaMercaderia> GetByComandaId(Guid ComandaId);
    }
}
