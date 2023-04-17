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

            Menu App = new Menu();
            App.Handle();
            App.OptionsLabel();
            
        }
    }
}