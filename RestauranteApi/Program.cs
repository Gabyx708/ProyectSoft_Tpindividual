using Application.Interfaces;
using Application.Services;
using Infrastructure.Commands;
using Infrastructure.Persistence;
using Infrastructure.Querys;
using Microsoft.EntityFrameworkCore;

namespace RestauranteApi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            //custom

            //Comanda
            builder.Services.AddScoped<IComandaCommand, ComandaCommand>();
            builder.Services.AddScoped<IComandaQuery, ComandaQuery>();
            builder.Services.AddScoped<IComandaService , ComandaService>();

            //Mercaderia 
            builder.Services.AddScoped<IMercaderiaCommand, MercaderiaCommand>();
            builder.Services.AddScoped<IMercaderiaQuery, MercaderiaQuery>();
            builder.Services.AddScoped<IMercaderiaService,MercaderiaService>();


            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}