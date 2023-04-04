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
        Task<FormaEntrega> createFormaentrega(string Descripcion);

        Task<FormaEntrega> UpdateFormaentrega(int FormaEntregaid);

        Task<FormaEntrega> deleteFormaentrega(int FormaEntregaid);
        Task<List<FormaEntrega>> getAll();

        Task<FormaEntrega> getByid(int FormaEntregaid);
    }
}
