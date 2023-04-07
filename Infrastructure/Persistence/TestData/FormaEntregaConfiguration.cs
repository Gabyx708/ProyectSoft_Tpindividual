using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Persistence.TestData
{
    public class FormaEntregaConfiguration : IEntityTypeConfiguration<FormaEntrega>
    {
        public void Configure(EntityTypeBuilder<FormaEntrega> builder)
        {
            builder.HasData
               (
                new FormaEntrega
                {   
                    FormaEntregaId= 10,
                    Descripcion = "Salon"
                },

                new FormaEntrega
                {   
                    FormaEntregaId = 20,
                    Descripcion="Delivery"
                },

                new FormaEntrega
                {   
                    FormaEntregaId= 30,
                    Descripcion="Pedidos Ya"
                }

               );
        }
    }
}
