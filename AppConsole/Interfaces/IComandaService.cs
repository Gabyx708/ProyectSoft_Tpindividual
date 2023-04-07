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
        Comanda createComanda(FormaEntrega comandaFormaEntrega, int precioTotal, DateTime Fecha);
        void updateComanda(int comandaId);
        void deleteComanda(int comandaId);
        List<Comanda> getAll();
        Comanda getByid(int comandaId);
    }
}
