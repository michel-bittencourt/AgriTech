using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AgriTech.Migrations
{
    /// <inheritdoc />
    public partial class Atualizacao17 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Adubo_Plantacao_PlantacaoId",
                table: "Adubo");

            migrationBuilder.DropIndex(
                name: "IX_Adubo_PlantacaoId",
                table: "Adubo");

            migrationBuilder.DropColumn(
                name: "NomePlanta",
                table: "Plantacao");

            migrationBuilder.DropColumn(
                name: "PlantacaoId",
                table: "Adubo");

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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AduboPlantacao");

            migrationBuilder.AddColumn<string>(
                name: "NomePlanta",
                table: "Plantacao",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "PlantacaoId",
                table: "Adubo",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Adubo_PlantacaoId",
                table: "Adubo",
                column: "PlantacaoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Adubo_Plantacao_PlantacaoId",
                table: "Adubo",
                column: "PlantacaoId",
                principalTable: "Plantacao",
                principalColumn: "Id");
        }
    }
}
