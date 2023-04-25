using Application.Interfaces;
using Application.Models.Comanda;
using Application.Models.Mercaderia;
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
        private readonly ITipoMercaderiaService _tipoMercaderiaService;

        public ComandaService(IComandaCommand Command, IComandaQuery Query, IComandaMercaderiaService commandaMercaderia, IMercaderiaService mercaderiaService, IFormaEntregaService formaEntregaService, ITipoMercaderiaService tipoMercaderiaService)
        {
            _command = Command;
            _query = Query;
            _commandaMercaderia = commandaMercaderia;
            _mercaderiaService = mercaderiaService;
            _formaEntregaService = formaEntregaService;
            _tipoMercaderiaService = tipoMercaderiaService;
        }

        public Comanda CreateComanda(ComandaRequest request)
        {
            var mercaderias = request.mercaderias;
            int precioComanda = 0;

            foreach (var platilloPrecio in mercaderias)
            {
               double precio = _mercaderiaService.GetById(platilloPrecio).precio;
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

        public ComandaGetResponse GetById(Guid ComandaId)
        {
            var comanda = _query.GetComanda(ComandaId);
            List<ComandaMercaderia> listaComandaMercaderia = _commandaMercaderia.GetByComandaId(ComandaId);
            List<MercaderiaGetResponse> mercaderiaGetResponses = new List<MercaderiaGetResponse>();

            foreach (var item in listaComandaMercaderia)
            {
                var mercaderia = _mercaderiaService.GetById(item.MercaderiaId);
                mercaderiaGetResponses.Add(mercaderia);
            }

            if (comanda != null)
            {
                return new ComandaGetResponse
                {
                    id = comanda.ComandaId,
                    total = comanda.PrecioTotal,
                    fecha = comanda.Fecha.ToString(),
                    mercaderias = mercaderiaGetResponses,
                    formaEntrega = _formaEntregaService.GetById(comanda.FormaEntregaId)
                };
            }
            return null;
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
