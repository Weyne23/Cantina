﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;
using WF_Aluno_EFCore.Models;

namespace Cantina.Migrations
{
    [DbContext(typeof(ApplicationDBContext))]
    [Migration("20210206150434_MigracaoInicial")]
    partial class MigracaoInicial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.2-rtm-10011")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Cantina.Cliente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Nome")
                        .HasMaxLength(100);

                    b.Property<int?>("PedId");

                    b.HasKey("Id");

                    b.HasIndex("PedId")
                        .IsUnique()
                        .HasFilter("[PedId] IS NOT NULL");

                    b.ToTable("Clientes");
                });

            modelBuilder.Entity("Cantina.Pedido", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.HasKey("Id");

                    b.ToTable("Pedidos");
                });

            modelBuilder.Entity("Cantina.Produto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Nome")
                        .HasMaxLength(100);

                    b.Property<int?>("PedidoId");

                    b.Property<decimal>("Valor");

                    b.HasKey("Id");

                    b.HasIndex("PedidoId");

                    b.ToTable("Produtos");
                });

            modelBuilder.Entity("Cantina.Cliente", b =>
                {
                    b.HasOne("Cantina.Pedido", "Ped")
                        .WithOne("Cli")
                        .HasForeignKey("Cantina.Cliente", "PedId");
                });

            modelBuilder.Entity("Cantina.Produto", b =>
                {
                    b.HasOne("Cantina.Pedido")
                        .WithMany("Prod")
                        .HasForeignKey("PedidoId");
                });
#pragma warning restore 612, 618
        }
    }
}
