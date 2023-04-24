using Application.Models.Comanda;
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
        Comanda CreateComanda(ComandaRequest comandaRequest);
        void UpdateComanda(int ComandaId);
        void DeleteComanda(int ComandaId);
        List<Comanda> GetAll();
        List<Comanda> GetByDate(string date);
        Comanda GetById(Guid ComandaId);
    }
}
