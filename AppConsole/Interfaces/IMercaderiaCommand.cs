using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IMercaderiaCommand
    {
        void InsertMercaderia(Mercaderia nuevaMercaderia);

        void RemoveMercaderia(int MercaderiaId);

        void UpdateMercaderia(int MercaderiaId);
    }
}
