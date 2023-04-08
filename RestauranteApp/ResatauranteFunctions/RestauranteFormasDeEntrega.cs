﻿using Application.Interfaces;
using Application.Services;
using Domain.Entities;
using Infrastructure.Commands;
using Infrastructure.Querys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestauranteApp.ResatauranteFunctions
{
    public class RestauranteFormasDeEntrega
    {
        private IFormaEntregaService service = new FormaEntregaServices(new FormaEntregaCommand(),new FormaEntregaQuery());

        public List<FormaEntrega> formaEntregas()
        {
            return service.getAll();
        }

        public FormaEntrega usarFormaEntrega(int id)
        {
            return service.getByid(id);
        }
    }
}
