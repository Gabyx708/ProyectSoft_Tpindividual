
using Application;
using Application.Interfaces;
using Domain.Entities;
using Infrastructure.Commands;
using Infrastructure.Persistence;
using Infrastructure.Querys;

namespace RestauranteApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("TEST DE APLICACION: \n");

            //prepareData desarrollo = new prepareData();

            IFormaEntregaCommand command = new FormaEntregaCommand();
            IFormaEntregaQuery query = new FormaEntregaQuery();

            FormaEntregaServices x = new FormaEntregaServices(command, query);
            x.createFormaentrega("en monopatin");

            /*if (desarrollo.FormaEntregaData())
            {
                Console.WriteLine("datos de prueba de Forma Entrega cargados exitosamete");
            }

            if (desarrollo.TipoMercaderiaData())
            {
                Console.WriteLine("datos de prueba de TipoMercaderia cargados exitosamete");
            }*/

        }
    }
}