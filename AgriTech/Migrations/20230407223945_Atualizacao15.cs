using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AgriTech.Migrations
{
    /// <inheritdoc />
    public partial class Atualizacao15 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Plantacao_Adubo_AduboId",
                table: "Plantacao");

            migrationBuilder.DropIndex(
                name: "IX_Plantacao_AduboId",
                table: "Plantacao");

            migrationBuilder.DropColumn(
                name: "NomeAdubo",
                table: "Plantacao");

            migrationBuilder.DropColumn(
                name: "TipoAdubo",
                table: "Plantacao");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataGerminou",
                table: "Plantacao",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataGerminacao",
                table: "Plantacao",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Adubo_Plantacao_PlantacaoId",
                table: "Adubo");

            migrationBuilder.DropIndex(
                name: "IX_Adubo_PlantacaoId",
                table: "Adubo");

            migrationBuilder.DropColumn(
                name: "PlantacaoId",
                table: "Adubo");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataGerminou",
                table: "Plantacao",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataGerminacao",
                table: "Plantacao",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NomeAdubo",
                table: "Plantacao",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "TipoAdubo",
                table: "Plantacao",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_Plantacao_AduboId",
                table: "Plantacao",
                column: "AduboId");

            migrationBuilder.AddForeignKey(
                name: "FK_Plantacao_Adubo_AduboId",
                table: "Plantacao",
                column: "AduboId",
                principalTable: "Adubo",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
