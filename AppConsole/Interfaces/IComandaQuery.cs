﻿using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IComandaQuery
    {
        List<Comanda> GetListaComanda();

        Comanda GetComanda(Guid ComandaId);

        List<Comanda> GetByDate(DateTime date);
    }
}
