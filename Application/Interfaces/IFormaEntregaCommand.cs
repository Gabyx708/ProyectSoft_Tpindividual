﻿using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IFormaEntregaCommand
    {
        void InsertFormaEntrega(FormaEntrega formaEntrega);

        void RemoveFormaEntrega(int formaentregaid);

        void UpdateFormaEntrega(int formaentregaid);
    }
}
