using Application.Interfaces;
using Application.Services;
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

            /*IComandaCommand command = new ComandaCommand();
            IComandaQuery query = new ComandaQuery();
            IComandaService comandaSer = new ComandaService(command, query);

            IFormaEntregaCommand fe_comanda = new FormaEntregaCommand();
            IFormaEntregaQuery fe_query = new FormaEntregaQuery();
            

            IFormaEntregaService x = new FormaEntregaServices(fe_comanda, fe_query);
            x.createFormaentrega("monopatin acuatico");
            x.createFormaentrega("avion");
            FormaEntrega test = x.getByid(1);

            DateTime now = new DateTime(2023, 06, 04);
            comandaSer.createComanda(test, 300,now);
           
            Console.WriteLine("ENCONTREEEE: " + test.Descripcion);*/



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