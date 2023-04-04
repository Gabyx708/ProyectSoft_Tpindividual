using Domain.Entities;
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
        public static AppDbcontext getInstance()
        {
            if (instance == null)
            {
                instance = new AppDbcontext();
            }

            return instance;
        }

        public DbSet<Comanda> Comandas { get; set; }
        public DbSet<ComandaMercaderia> comandaMercaderias { get; set; }
        public DbSet<FormaEntrega> FormaEntregas { get; set; }
        public DbSet<Mercaderia> Mercaderias { get; set; }
        public DbSet<TipoMercaderia> TipoMercaderias { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=localhost;Database=DbTpindivual;Trusted_Connection=true;Encrypt=False;TrustServerCertificate=False");

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Comanda>(entity =>
            {
                entity.HasKey(e => e.ComandaId);
                entity.Property(e => e.ComandaId).ValueGeneratedOnAdd();

                entity.HasOne<FormaEntrega>(c => c.FormaEntrega)
                       .WithMany(fe => fe.comandas)
                       .HasForeignKey(c => c.FormaEntregaId);
            
            }
            );

            modelBuilder.Entity<Mercaderia>(entity =>
            {
                entity.HasKey(e => e.MercaderiaId);
                entity.Property(e => e.MercaderiaId).ValueGeneratedOnAdd();

                entity.HasOne<TipoMercaderia>(m => m.TipoMercaderia)
                       .WithMany(tp => tp.mercaderias)
                       .HasForeignKey(m => m.TipoMercaderiaId);
            });


            modelBuilder.Entity<ComandaMercaderia>(entity =>
            {
                entity.HasKey(e => e.ComandaMercaderiaId);
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
                entity.HasKey(e => e.TipoMercaderiaId);
                entity.Property(e => e.TipoMercaderiaId).ValueGeneratedOnAdd();

            });

            modelBuilder.Entity<FormaEntrega>(entity => {
                entity.HasKey(e => e.FormaEntregaId);
                entity.Property(e => e.FormaEntregaId).ValueGeneratedOnAdd();
            });

          

                
        }



    }
}
