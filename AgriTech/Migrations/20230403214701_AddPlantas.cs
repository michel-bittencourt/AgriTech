using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AgriTech.Migrations
{
    /// <inheritdoc />
    public partial class AddPlantas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Observacao",
                table: "Adubo",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DescricaoMontagem",
                table: "Adubo",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "Planta",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomeCientifico = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NomePopular = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EstacaoCrescimento = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ComprimentoPlantio = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LarguraPlantio = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProfundidadePlantio = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhSolo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UmidadeSolo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TempoGerminacao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TempoColheita = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TempoSecagem = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Observacoes = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Planta", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Planta");

            migrationBuilder.AlterColumn<string>(
                name: "Observacao",
                table: "Adubo",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "DescricaoMontagem",
                table: "Adubo",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }
    }
}
