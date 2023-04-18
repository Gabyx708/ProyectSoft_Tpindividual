using Domain.Entities;
using Infrastructure.Persistence.TestData;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Persistence
{
    public class AppDbcontext : DbContext 
    {   

        private static AppDbcontext instance = null;
        public static AppDbcontext GetInstance()
        {
            if (instance == null)
            {
                instance = new AppDbcontext();
            }

            return instance;
        }

        public DbSet<Comanda> Comandas { get; set; }
        public DbSet<ComandaMercaderia> ComandaMercaderias { get; set; }
        public DbSet<FormaEntrega> FormaEntregas { get; set; }
        public DbSet<Mercaderia> Mercaderias { get; set; }
        public DbSet<TipoMercaderia> TipoMercaderias { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=localhost;Database=DbRestaurant;Trusted_Connection=true;Encrypt=False;TrustServerCertificate=False");

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Comanda>(entity =>
            {
                entity.ToTable("Comanda");

                entity.HasKey(e => e.ComandaId);
                entity.Property(e => e.ComandaId).ValueGeneratedOnAdd();
                entity.Property(e => e.FormaEntregaId).IsRequired();
                entity.Property(e => e.PrecioTotal).IsRequired();
                entity.Property(e => e.Fecha).IsRequired();

                entity.HasOne<FormaEntrega>(c => c.FormaEntrega)
                       .WithMany(fe => fe.Comandas)
                       .HasForeignKey(c => c.FormaEntregaId);
            
            }
            );

            modelBuilder.Entity<Mercaderia>(entity =>
            {
                entity.ToTable("Mercaderia");

                entity.HasKey(e => e.MercaderiaId);
                entity.Property(e => e.MercaderiaId).ValueGeneratedOnAdd();
                entity.Property(e => e.Precio).IsRequired();
                entity.Property(e => e.Nombre).HasMaxLength(50).IsRequired();
                entity.Property(e => e.Ingredientes).HasMaxLength(255).IsRequired();
                entity.Property(e => e.Preparacion).HasMaxLength(255).IsRequired();
                entity.Property(e => e.Imagen).HasMaxLength(255).IsRequired();

                entity.HasOne<TipoMercaderia>(m => m.TipoMercaderia)
                       .WithMany(tp => tp.Mercaderias)
                       .HasForeignKey(m => m.TipoMercaderiaId);
            });


            modelBuilder.Entity<ComandaMercaderia>(entity =>
            {
                entity.ToTable("ComandaMercaderia");

                entity.HasKey(e => e.ComandaMercaderiaId);
                entity.HasKey(e => new { e.MercaderiaId, e.ComandaId });
                entity.Property(e => e.ComandaMercaderiaId).ValueGeneratedOnAdd();

                entity.HasOne<Mercaderia>(m => m.Mercaderia)
                    .WithMany(mc => mc.ComandaMercaderias)
                    .HasForeignKey(m => m.MercaderiaId);

                entity.HasOne<Comanda>(c => c.Comanda)
                      .WithMany(cm => cm.ComandaMercaderias)
                      .HasForeignKey(c => c.ComandaId);
            });

            modelBuilder.Entity<TipoMercaderia>(entity =>
            {
                entity.ToTable("TipoMercaderia");

                entity.HasKey(e => e.TipoMercaderiaId);
                entity.Property(e => e.TipoMercaderiaId).ValueGeneratedOnAdd();
                entity.Property(e => e.Descripcion).HasMaxLength(50).IsRequired();

            });

            modelBuilder.Entity<FormaEntrega>(entity => {

                entity.ToTable("FormaEntrega");

                entity.HasKey(e => e.FormaEntregaId);
                entity.Property(e => e.FormaEntregaId).ValueGeneratedOnAdd();
                entity.Property(e => e.Descripcion).HasMaxLength(50).IsRequired();

            });

            //carga de datos iniciales
            modelBuilder.ApplyConfiguration(new FormaEntregaConfiguration());
            modelBuilder.ApplyConfiguration(new TipoMercaderiaConfiguration());
            modelBuilder.ApplyConfiguration(new MercaderiaConfiguration());

        }



    }
}
