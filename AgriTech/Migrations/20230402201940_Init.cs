using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AgriTech.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.CreateTable(
                name: "Adubo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tipo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DescricaoMontagem = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Observacao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PlantaId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Adubo", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Adubo_Planta_PlantaId",
                        column: x => x.PlantaId,
                        principalTable: "Planta",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Adubo_PlantaId",
                table: "Adubo",
                column: "PlantaId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Adubo");

            migrationBuilder.DropTable(
                name: "Planta");
        }
    }
}
