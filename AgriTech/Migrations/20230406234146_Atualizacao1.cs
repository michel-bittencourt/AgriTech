using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AgriTech.Migrations
{
    /// <inheritdoc />
    public partial class Atualizacao1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Adubo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tipo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Ingredientes = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DescricaoMontagem = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DescricaoUso = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Observacao = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Adubo", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Planta",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomeCientifico = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NomePopular = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EstacaoParaPlantar = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EstacaoParaColher = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ComprimentoPlantio = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LarguraPlantio = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProfundidadePlantio = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhSolo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UmidadeSolo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ComoRegar = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DiasGerminacao = table.Column<int>(type: "int", nullable: false),
                    ComoGerminar = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DiasColheita = table.Column<int>(type: "int", nullable: false),
                    ComoColher = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TempoSecagem = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ComoSecar = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Observacoes = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Planta", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Plantacao",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomePlanta = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Lote = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PlantaId = table.Column<int>(type: "int", nullable: false),
                    AduboId = table.Column<int>(type: "int", nullable: false),
                    DataGerminacao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Germinou = table.Column<bool>(type: "bit", nullable: false),
                    DataGerminou = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DataPlantio = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DataColheita = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Plantacao", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Plantacao_Adubo_AduboId",
                        column: x => x.AduboId,
                        principalTable: "Adubo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Plantacao_Planta_PlantaId",
                        column: x => x.PlantaId,
                        principalTable: "Planta",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Plantacao_AduboId",
                table: "Plantacao",
                column: "AduboId");

            migrationBuilder.CreateIndex(
                name: "IX_Plantacao_PlantaId",
                table: "Plantacao",
                column: "PlantaId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Plantacao");

            migrationBuilder.DropTable(
                name: "Adubo");

            migrationBuilder.DropTable(
                name: "Planta");
        }
    }
}
