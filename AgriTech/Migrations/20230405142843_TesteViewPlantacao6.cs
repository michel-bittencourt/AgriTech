using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AgriTech.Migrations
{
    /// <inheritdoc />
    public partial class TesteViewPlantacao6 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PlantaId",
                table: "Adubo",
                type: "int",
                nullable: true);

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

            migrationBuilder.DropIndex(
                name: "IX_Adubo_PlantaId",
                table: "Adubo");

            migrationBuilder.DropColumn(
                name: "PlantaId",
                table: "Adubo");
        }
    }
}
