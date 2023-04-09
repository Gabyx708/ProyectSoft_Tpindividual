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
        FormaEntrega createFormaentrega(string Descripcion);
        void UpdateFormaentrega(int FormaEntregaid);
        void deleteFormaentrega(int FormaEntregaid);
        List<FormaEntrega> getAll();
        FormaEntrega getByid(int FormaEntregaid);
    }
}
