using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AgriTech.Migrations
{
    /// <inheritdoc />
    public partial class Atualizacao18 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NomeCientifico",
                table: "Plantacao");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "NomeCientifico",
                table: "Plantacao",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
