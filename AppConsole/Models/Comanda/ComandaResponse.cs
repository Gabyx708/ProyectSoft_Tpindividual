using Application.Models.FormaEntrega;
using Application.Models.Mercaderia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Models.Comanda
{
    public class ComandaResponse
    {
        public Guid id { get; set; }

        public List<MercaderiaComandaResponse> mercaderias { get; set; }

        public FormaEntrega_ formaEntrega { get; set; }

        public double total { get; set; }

        public string fecha { get; set; }
    }
}
