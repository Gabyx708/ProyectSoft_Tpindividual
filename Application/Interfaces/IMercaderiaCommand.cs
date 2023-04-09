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
        void insertMercaderia(Mercaderia nuevaMercaderia);

        void removeMercaderia(int mercaderiaId);

        void updateMercaderia(int mercaderiaId);
    }
}
