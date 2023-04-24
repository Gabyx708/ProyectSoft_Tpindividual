using Application.Models.FormaEntrega;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IFormaEntregaService
    { 
        //el service debe tener los metodos de CRUD
        FormaEntrega CreateFormaEntrega(string Descripcion);
        void UpdateFormaEntrega(int FormaEntregaId);
        void DeleteFormaEntrega(int FormaEntregaId);
        List<FormaEntrega> GetAll();
        FormaEntrega_ GetById(int FormaEntregaId);
    }
}
