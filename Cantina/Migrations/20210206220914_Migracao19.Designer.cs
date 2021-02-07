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
    [Migration("20210206220914_Migracao19")]
    partial class Migracao19
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

                    b.HasKey("Id");

                    b.ToTable("Clientes");
                });

            modelBuilder.Entity("Cantina.Pedido", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("CliId");

                    b.Property<bool>("Delivery");

                    b.Property<bool>("Finalizado");

                    b.Property<int?>("ProdId");

                    b.HasKey("Id");

                    b.HasIndex("CliId");

                    b.HasIndex("ProdId");

                    b.ToTable("Pedidos");
                });

            modelBuilder.Entity("Cantina.Pedido_Produto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("PedidoId");

                    b.Property<int?>("ProdutoId");

                    b.HasKey("Id");

                    b.HasIndex("PedidoId");

                    b.HasIndex("ProdutoId");

                    b.ToTable("Produtos_Produto");
                });

            modelBuilder.Entity("Cantina.Produto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Descricao")
                        .HasMaxLength(100);

                    b.Property<string>("Nome")
                        .HasMaxLength(100);

                    b.Property<decimal>("Valor");

                    b.HasKey("Id");

                    b.ToTable("Produtos");
                });

            modelBuilder.Entity("Cantina.Pedido", b =>
                {
                    b.HasOne("Cantina.Cliente", "Cli")
                        .WithMany()
                        .HasForeignKey("CliId");

                    b.HasOne("Cantina.Produto", "Prod")
                        .WithMany()
                        .HasForeignKey("ProdId");
                });

            modelBuilder.Entity("Cantina.Pedido_Produto", b =>
                {
                    b.HasOne("Cantina.Pedido", "Pedido")
                        .WithMany()
                        .HasForeignKey("PedidoId");

                    b.HasOne("Cantina.Produto", "Produto")
                        .WithMany()
                        .HasForeignKey("ProdutoId");
                });
#pragma warning restore 612, 618
        }
    }
}
