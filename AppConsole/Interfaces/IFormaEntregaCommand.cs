using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IFormaEntregaCommand
    {
        void InsertFormaEntrega(FormaEntrega FormaEntrega);

        void RemoveFormaEntrega(int FormaEntregaid);

        void UpdateFormaEntrega(int FormaEntregaid);
    }
}
