using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Models.Comanda
{
    public class ComandaRequest
    {
        public IList<int> mercaderias { get; set; }
        public int formaEntrega { get; set; }
    }
}
