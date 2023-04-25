using Application.Models.TipoMercaderia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Models.Mercaderia
{
    public class MercaderiaGetResponse
    {
        public int id { get; set; }
        public string nombre { get; set; }

        public double precio { get; set; }

        public TipoMercaderiaResponse tipo { get; set; }

        public string imagen { get; set; }
    }
}
