﻿using Application.Interfaces;
using Domain.Entities;
using Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Querys
{
    public class ComandaMercaderiaQuery : IComandaMercaderiaQuery
    {
        private readonly AppDbcontext context;

        public ComandaMercaderiaQuery()
        {
            context = AppDbcontext.getInstance();
        }

        public ComandaMercaderia GetComanda(int comandaMercaderiaid)
        {
            var ComandaMercaderiaEncontrada = context.Find<ComandaMercaderia>(comandaMercaderiaid);
            if (ComandaMercaderiaEncontrada != null)
            {
                return ComandaMercaderiaEncontrada;
            }
            return null;
        }

        public List<ComandaMercaderia> GetListaComandaMercaderia()
        {
            return context.comandaMercaderias.ToList<ComandaMercaderia>();
        }

        public List<ComandaMercaderia> GetListaComandaMercaderiaBycomandaId(Guid comandaid)
        {
            return context.comandaMercaderias.Where(cm => cm.ComandaId.Equals(comandaid)).ToList();
        }
    }
}
