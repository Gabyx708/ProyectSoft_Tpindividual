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

            Menu test = new Menu();
            test.handle();
            Console.Write("Ingresa una opcion: ");
            int op = int.Parse(Console.ReadLine());
            test.elegirOpcion(op);
            
        }
    }
}