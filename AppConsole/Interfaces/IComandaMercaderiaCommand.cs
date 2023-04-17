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
        void InsertComandaMercaderia(ComandaMercaderia NuevoComandaMercaderia);

        void RemoveComandaMercaderia(int ComandaMercaderiaId);

        void UpdateComandaMercaderia(int ComandaMercaderiaId);
    }
}
