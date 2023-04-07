using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IComandaMercaderiaCommand
    {
        void insertComandaMercaderia(ComandaMercaderia nuevoComandaMercaderia);

        void removeComandaMercaderia(int comandaMercaderiaId);

        void updateComandaMercaderia(int comandaMercaderiaId);
    }
}
