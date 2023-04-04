﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class TipoMercaderia
    {
        public int TipoMercaderiaId { get; set; }
        public string Descripcion { get; set; }

        public IList<Mercaderia> mercaderias { get; set; }
    }
}
