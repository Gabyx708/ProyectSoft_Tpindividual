﻿// <auto-generated />
using System;
using Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Infrastructure.Migrations
{
    [DbContext(typeof(AppDbcontext))]
    partial class AppDbcontextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Domain.Entities.Comanda", b =>
                {
                    b.Property<Guid>("ComandaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<int>("FormaEntregaId")
                        .HasColumnType("int");

                    b.Property<int>("PrecioTotal")
                        .HasColumnType("int");

                    b.HasKey("ComandaId");

                    b.HasIndex("FormaEntregaId");

                    b.ToTable("Comandas");
                });

            modelBuilder.Entity("Domain.Entities.ComandaMercaderia", b =>
                {
                    b.Property<int>("ComandaMercaderiaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ComandaMercaderiaId"));

                    b.Property<Guid>("ComandaId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("MercaderiaId")
                        .HasColumnType("int");

                    b.HasKey("ComandaMercaderiaId");

                    b.HasIndex("ComandaId");

                    b.HasIndex("MercaderiaId");

                    b.ToTable("comandaMercaderias");
                });

            modelBuilder.Entity("Domain.Entities.FormaEntrega", b =>
                {
                    b.Property<int>("FormaEntregaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("FormaEntregaId"));

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("FormaEntregaId");

                    b.ToTable("FormaEntregas");
                });

            modelBuilder.Entity("Domain.Entities.Mercaderia", b =>
                {
                    b.Property<int>("MercaderiaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MercaderiaId"));

                    b.Property<string>("Imagen")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ingredientes")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Precio")
                        .HasColumnType("int");

                    b.Property<string>("Preparacion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TipoMercaderiaId")
                        .HasColumnType("int");

                    b.HasKey("MercaderiaId");

                    b.HasIndex("TipoMercaderiaId");

                    b.ToTable("Mercaderias");
                });

            modelBuilder.Entity("Domain.Entities.TipoMercaderia", b =>
                {
                    b.Property<int>("TipoMercaderiaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TipoMercaderiaId"));

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TipoMercaderiaId");

                    b.ToTable("TipoMercaderias");
                });

            modelBuilder.Entity("Domain.Entities.Comanda", b =>
                {
                    b.HasOne("Domain.Entities.FormaEntrega", "FormaEntrega")
                        .WithMany("comandas")
                        .HasForeignKey("FormaEntregaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("FormaEntrega");
                });

            modelBuilder.Entity("Domain.Entities.ComandaMercaderia", b =>
                {
                    b.HasOne("Domain.Entities.Comanda", "Comanda")
                        .WithMany("ComandaMercaderias")
                        .HasForeignKey("ComandaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.Mercaderia", "Mercaderia")
                        .WithMany("ComandaMercaderias")
                        .HasForeignKey("MercaderiaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Comanda");

                    b.Navigation("Mercaderia");
                });

            modelBuilder.Entity("Domain.Entities.Mercaderia", b =>
                {
                    b.HasOne("Domain.Entities.TipoMercaderia", "TipoMercaderia")
                        .WithMany("mercaderias")
                        .HasForeignKey("TipoMercaderiaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("TipoMercaderia");
                });

            modelBuilder.Entity("Domain.Entities.Comanda", b =>
                {
                    b.Navigation("ComandaMercaderias");
                });

            modelBuilder.Entity("Domain.Entities.FormaEntrega", b =>
                {
                    b.Navigation("comandas");
                });

            modelBuilder.Entity("Domain.Entities.Mercaderia", b =>
                {
                    b.Navigation("ComandaMercaderias");
                });

            modelBuilder.Entity("Domain.Entities.TipoMercaderia", b =>
                {
                    b.Navigation("mercaderias");
                });
#pragma warning restore 612, 618
        }
    }
}
