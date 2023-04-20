using Application.Interfaces;
using Application.Services;
using Domain.Entities;
using Infrastructure.Commands;
using Infrastructure.Persistence;
using Infrastructure.Querys;
using RestauranteApp.Logs;

namespace RestauranteApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string LogPath = @"D:\\1_C_2023_UNI\\ProyectSoft_Tpindividual\\RestauranteApp\\Logs\\logs\\";
            LogCreator logs = new LogCreator(LogPath);

            Menu App = new Menu(logs);
            App.Handle();
            App.OptionsLabel();
            
        }
    }
}