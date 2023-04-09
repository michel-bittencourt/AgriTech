using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AgriTech.Migrations
{
    /// <inheritdoc />
    public partial class V10 : Migration
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
                    Tipo = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Nome = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    Ingredientes = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    DescricaoMontagem = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: true),
                    DescricaoUso = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: true),
                    Observacao = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true)
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
                    NomeCientifico = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    NomePopular = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    EstacaoParaPlantar = table.Column<string>(type: "nvarchar(35)", maxLength: 35, nullable: true),
                    EstacaoParaColher = table.Column<string>(type: "nvarchar(35)", maxLength: 35, nullable: true),
                    ComprimentoPlantio = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    LarguraPlantio = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    ProfundidadePlantio = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    PhSolo = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    UmidadeSolo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ComoRegar = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: true),
                    DiasGerminacao = table.Column<int>(type: "int", nullable: false),
                    ComoGerminar = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: true),
                    DiasColheita = table.Column<int>(type: "int", nullable: false),
                    ComoColher = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: true),
                    TempoSecagem = table.Column<int>(type: "int", nullable: true),
                    ComoSecar = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: true),
                    Observacoes = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true)
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
                    Lote = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NomePlanta = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NomeCientifico = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TipoAdubo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NomeAdubo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DataGerminacao = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Germinou = table.Column<bool>(type: "bit", nullable: false),
                    DataGerminou = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DataPlantio = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DataColheita = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PlantaId = table.Column<int>(type: "int", nullable: false),
                    AduboId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Plantacao", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Plantacao_Planta_PlantaId",
                        column: x => x.PlantaId,
                        principalTable: "Planta",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AduboPlantacao",
                columns: table => new
                {
                    AduboId = table.Column<int>(type: "int", nullable: false),
                    plantacaosId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AduboPlantacao", x => new { x.AduboId, x.plantacaosId });
                    table.ForeignKey(
                        name: "FK_AduboPlantacao_Adubo_AduboId",
                        column: x => x.AduboId,
                        principalTable: "Adubo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AduboPlantacao_Plantacao_plantacaosId",
                        column: x => x.plantacaosId,
                        principalTable: "Plantacao",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AduboPlantacao_plantacaosId",
                table: "AduboPlantacao",
                column: "plantacaosId");

            migrationBuilder.CreateIndex(
                name: "IX_Plantacao_PlantaId",
                table: "Plantacao",
                column: "PlantaId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AduboPlantacao");

            migrationBuilder.DropTable(
                name: "Adubo");

            migrationBuilder.DropTable(
                name: "Plantacao");

            migrationBuilder.DropTable(
                name: "Planta");
        }
    }
}
