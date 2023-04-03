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
            
            }
            );

            modelBuilder.Entity<Mercaderia>(entity =>
            {
                entity.HasKey(e => e.MercaderiaId);
                entity.Property(e => e.MercaderiaId).ValueGeneratedOnAdd();
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

                
        }



    }
}
