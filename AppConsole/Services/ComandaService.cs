using Application.Interfaces;
using Application.Models.Comanda;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public class ComandaService : IComandaService
    {
        private readonly IComandaCommand _command;
        private readonly IComandaQuery _query;
        private readonly IComandaMercaderiaService _commandaMercaderia;
        private readonly IMercaderiaService _mercaderiaService;
        private readonly IFormaEntregaService _formaEntregaService;

        public ComandaService(IComandaCommand Command, IComandaQuery Query, IComandaMercaderiaService commandaMercaderia, IMercaderiaService mercaderiaService, IFormaEntregaService formaEntregaService)
        {
            _command = Command;
            _query = Query;
            _commandaMercaderia = commandaMercaderia;
            _mercaderiaService = mercaderiaService;
            _formaEntregaService = formaEntregaService;
        }

        public Comanda CreateComanda(ComandaRequest request)
        {
            var mercaderias = request.mercaderias;
            int precioComanda = 0;

            foreach (var platilloPrecio in mercaderias)
            {
                int precio = _mercaderiaService.GetById(platilloPrecio).Precio;
               precioComanda =(int)precio+ precioComanda;
            }

            var comanda = new Comanda
            {
                PrecioTotal = precioComanda,
                Fecha = DateTime.Now,
                FormaEntregaId = request.formaEntrega
            };

            _command.InsertComanda(comanda);

            foreach (var platillo in mercaderias)
            {
                _commandaMercaderia.CreateComandaMercaderia(platillo, comanda.ComandaId);
            }

            return comanda;
        }

        public void DeleteComanda(int ComandaId)
        {
            _command.RemoveComanda(ComandaId);
        }

        public List<Comanda> GetAll()
        {
            return _query.GetListaComanda();
        }

        public Comanda GetById(Guid ComandaId)
        {
            var comanda = _query.GetComanda(ComandaId);

            var comandaGetResponse = new ComandaGetResponse
            {
                id = comanda.ComandaId,
                total = comanda.PrecioTotal,
                fecha = comanda.Fecha.ToString(),
                formaEntrega = _formaEntregaService.GetById(comanda.FormaEntregaId),
                mercaderias = null
            };

            return _query.GetComanda(ComandaId);
        }

        public void UpdateComanda(int ComandaId)
        {
            _command.UpdateComanda(ComandaId);
        }

        public List<Comanda> GetByDate(string fecha)
        {
            DateTime dateRequest;

            try
            {
                string[] ArrayFecha = fecha.Split("-");

                int year = int.Parse(ArrayFecha[0]);
                int month = int.Parse(ArrayFecha[1]);
                int day = int.Parse(ArrayFecha[2]);

                dateRequest = new DateTime(year, month, day);
            }
            catch (Exception e)
            {
                return null;
            }
            
            return _query.GetByDate(dateRequest);
        }
    }
}
