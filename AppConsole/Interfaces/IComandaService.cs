using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IComandaService
    {
        Comanda CreateComanda(FormaEntrega ComandaFormaEntrega, int PrecioTotal, DateTime Fecha);
        void UpdateComanda(int ComandaId);
        void DeleteComanda(int ComandaId);
        List<Comanda> GetAll();
        Comanda GetById(Guid ComandaId);
    }
}
