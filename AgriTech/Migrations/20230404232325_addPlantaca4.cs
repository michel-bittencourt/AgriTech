using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AgriTech.Migrations
{
    /// <inheritdoc />
    public partial class addPlantaca4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Plantacao_Adubo_AduboId",
                table: "Plantacao");

            migrationBuilder.DropForeignKey(
                name: "FK_Plantacao_Planta_PlantaId",
                table: "Plantacao");

            migrationBuilder.DropIndex(
                name: "IX_Plantacao_AduboId",
                table: "Plantacao");

            migrationBuilder.DropIndex(
                name: "IX_Plantacao_PlantaId",
                table: "Plantacao");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Plantacao_AduboId",
                table: "Plantacao",
                column: "AduboId");

            migrationBuilder.CreateIndex(
                name: "IX_Plantacao_PlantaId",
                table: "Plantacao",
                column: "PlantaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Plantacao_Adubo_AduboId",
                table: "Plantacao",
                column: "AduboId",
                principalTable: "Adubo",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Plantacao_Planta_PlantaId",
                table: "Plantacao",
                column: "PlantaId",
                principalTable: "Planta",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
