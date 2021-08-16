using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Controle.Migrations
{
    public partial class FotoVeiculo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Marcas_Modelos_ModelosIDModelo",
                table: "Marcas");

            migrationBuilder.DropForeignKey(
                name: "FK_Modelos_Veiculos_VeiculoIDVeiculo",
                table: "Modelos");

            migrationBuilder.DropIndex(
                name: "IX_Modelos_VeiculoIDVeiculo",
                table: "Modelos");

            migrationBuilder.DropIndex(
                name: "IX_Marcas_ModelosIDModelo",
                table: "Marcas");

            migrationBuilder.DropColumn(
                name: "VeiculoIDVeiculo",
                table: "Modelos");

            migrationBuilder.DropColumn(
                name: "ModelosIDModelo",
                table: "Marcas");

            migrationBuilder.AddColumn<byte[]>(
                name: "ImageUpload",
                table: "Veiculos",
                type: "varbinary(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageUpload",
                table: "Veiculos");

            migrationBuilder.AddColumn<int>(
                name: "VeiculoIDVeiculo",
                table: "Modelos",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ModelosIDModelo",
                table: "Marcas",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Modelos_VeiculoIDVeiculo",
                table: "Modelos",
                column: "VeiculoIDVeiculo");

            migrationBuilder.CreateIndex(
                name: "IX_Marcas_ModelosIDModelo",
                table: "Marcas",
                column: "ModelosIDModelo");

            migrationBuilder.AddForeignKey(
                name: "FK_Marcas_Modelos_ModelosIDModelo",
                table: "Marcas",
                column: "ModelosIDModelo",
                principalTable: "Modelos",
                principalColumn: "IDModelo",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Modelos_Veiculos_VeiculoIDVeiculo",
                table: "Modelos",
                column: "VeiculoIDVeiculo",
                principalTable: "Veiculos",
                principalColumn: "IDVeiculo",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
