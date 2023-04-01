﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AgriTech.Migrations
{
    /// <inheritdoc />
    public partial class AlterandoDadosAdubo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Ingredientes",
                table: "Adubo",
                newName: "Tipo");

            migrationBuilder.AddColumn<int>(
                name: "PlantaId",
                table: "Adubo",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Planta",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomeCientifico = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NomePopular = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Estacao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Profundidade = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DistanciaComprimento = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DistanciaLargura = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Ph = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Umidade = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DiasParaColher = table.Column<int>(type: "int", nullable: false),
                    TempoParaSecagem = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Planta", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Adubo_PlantaId",
                table: "Adubo",
                column: "PlantaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Adubo_Planta_PlantaId",
                table: "Adubo",
                column: "PlantaId",
                principalTable: "Planta",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Adubo_Planta_PlantaId",
                table: "Adubo");

            migrationBuilder.DropTable(
                name: "Planta");

            migrationBuilder.DropIndex(
                name: "IX_Adubo_PlantaId",
                table: "Adubo");

            migrationBuilder.DropColumn(
                name: "PlantaId",
                table: "Adubo");

            migrationBuilder.RenameColumn(
                name: "Tipo",
                table: "Adubo",
                newName: "Ingredientes");
        }
    }
}
