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
        Task InsertFormaEntrega(FormaEntrega formaEntrega);

        Task RemoveFormaEntrega(int formaentregaid);
    }
}
