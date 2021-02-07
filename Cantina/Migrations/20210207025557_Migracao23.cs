using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Cantina.Migrations
{
    public partial class Migracao23 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pedidos_Clientes_CliId",
                table: "Pedidos");

            migrationBuilder.DropForeignKey(
                name: "FK_Pedidos_Produtos_ProdId",
                table: "Pedidos");

            migrationBuilder.DropTable(
                name: "Produtos_Produto");

            migrationBuilder.DropIndex(
                name: "IX_Pedidos_CliId",
                table: "Pedidos");

            migrationBuilder.DropColumn(
                name: "CliId",
                table: "Pedidos");

            migrationBuilder.DropColumn(
                name: "Delivery",
                table: "Pedidos");

            migrationBuilder.RenameColumn(
                name: "ProdId",
                table: "Pedidos",
                newName: "ClienteId");

            migrationBuilder.RenameIndex(
                name: "IX_Pedidos_ProdId",
                table: "Pedidos",
                newName: "IX_Pedidos_ClienteId");

            migrationBuilder.AddColumn<int>(
                name: "PedidoId",
                table: "Produtos",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DataCompra",
                table: "Pedidos",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Endereco",
                table: "Clientes",
                maxLength: 100,
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Produtos_PedidoId",
                table: "Produtos",
                column: "PedidoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Pedidos_Clientes_ClienteId",
                table: "Pedidos",
                column: "ClienteId",
                principalTable: "Clientes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Produtos_Pedidos_PedidoId",
                table: "Produtos",
                column: "PedidoId",
                principalTable: "Pedidos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pedidos_Clientes_ClienteId",
                table: "Pedidos");

            migrationBuilder.DropForeignKey(
                name: "FK_Produtos_Pedidos_PedidoId",
                table: "Produtos");

            migrationBuilder.DropIndex(
                name: "IX_Produtos_PedidoId",
                table: "Produtos");

            migrationBuilder.DropColumn(
                name: "PedidoId",
                table: "Produtos");

            migrationBuilder.DropColumn(
                name: "DataCompra",
                table: "Pedidos");

            migrationBuilder.DropColumn(
                name: "Endereco",
                table: "Clientes");

            migrationBuilder.RenameColumn(
                name: "ClienteId",
                table: "Pedidos",
                newName: "ProdId");

            migrationBuilder.RenameIndex(
                name: "IX_Pedidos_ClienteId",
                table: "Pedidos",
                newName: "IX_Pedidos_ProdId");

            migrationBuilder.AddColumn<int>(
                name: "CliId",
                table: "Pedidos",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Delivery",
                table: "Pedidos",
                nullable: false,
                defaultValue: false);

            migrationBuilder.CreateTable(
                name: "Produtos_Produto",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    PedidoId = table.Column<int>(nullable: true),
                    ProdutoId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Produtos_Produto", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Produtos_Produto_Pedidos_PedidoId",
                        column: x => x.PedidoId,
                        principalTable: "Pedidos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Produtos_Produto_Produtos_ProdutoId",
                        column: x => x.ProdutoId,
                        principalTable: "Produtos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Pedidos_CliId",
                table: "Pedidos",
                column: "CliId");

            migrationBuilder.CreateIndex(
                name: "IX_Produtos_Produto_PedidoId",
                table: "Produtos_Produto",
                column: "PedidoId");

            migrationBuilder.CreateIndex(
                name: "IX_Produtos_Produto_ProdutoId",
                table: "Produtos_Produto",
                column: "ProdutoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Pedidos_Clientes_CliId",
                table: "Pedidos",
                column: "CliId",
                principalTable: "Clientes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Pedidos_Produtos_ProdId",
                table: "Pedidos",
                column: "ProdId",
                principalTable: "Produtos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
