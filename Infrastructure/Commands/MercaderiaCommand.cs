﻿using Application.Interfaces;
using Domain.Entities;
using Infrastructure.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Commands
{
    public class MercaderiaCommand : IMercaderiaCommand
    {
        private readonly AppDbcontext context;

        public MercaderiaCommand()
        {
            context = AppDbcontext.getInstance();
        }

        public void insertMercaderia(Mercaderia nuevaMercaderia)
        {
            context.Add(nuevaMercaderia);
            context.SaveChanges();
        }

        public void removeMercaderia(int mercaderiaId)
        {
            Mercaderia mercaderiaEliminar = context.Mercaderias.Single(m => m.MercaderiaId == mercaderiaId);
            context.Remove<Mercaderia>(mercaderiaEliminar);
            context.SaveChanges();
        }

        public void updateMercaderia(int mercaderiaId)
        {
            Mercaderia mercaderiaUpdate = context.Mercaderias.Single(m => m.MercaderiaId == mercaderiaId);
            context.Update<Mercaderia>(mercaderiaUpdate);
            context.SaveChanges();
        }
    }
}