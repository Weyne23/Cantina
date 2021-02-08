using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Cantina.Migrations
{
    public partial class MigracaoTeste : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Clientes_Pedidos_PedId",
                table: "Clientes");

            migrationBuilder.DropIndex(
                name: "IX_Clientes_PedId",
                table: "Clientes");

            migrationBuilder.DropColumn(
                name: "PedId",
                table: "Clientes");

            migrationBuilder.AddColumn<int>(
                name: "CliId",
                table: "Pedidos",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Pedidos_CliId",
                table: "Pedidos",
                column: "CliId");

            migrationBuilder.AddForeignKey(
                name: "FK_Pedidos_Clientes_CliId",
                table: "Pedidos",
                column: "CliId",
                principalTable: "Clientes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pedidos_Clientes_CliId",
                table: "Pedidos");

            migrationBuilder.DropIndex(
                name: "IX_Pedidos_CliId",
                table: "Pedidos");

            migrationBuilder.DropColumn(
                name: "CliId",
                table: "Pedidos");

            migrationBuilder.AddColumn<int>(
                name: "PedId",
                table: "Clientes",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Clientes_PedId",
                table: "Clientes",
                column: "PedId",
                unique: true,
                filter: "[PedId] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_Clientes_Pedidos_PedId",
                table: "Clientes",
                column: "PedId",
                principalTable: "Pedidos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
