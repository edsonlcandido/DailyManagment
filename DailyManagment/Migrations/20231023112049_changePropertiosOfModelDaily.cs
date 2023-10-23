using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DailyManagment.Migrations
{
    /// <inheritdoc />
    public partial class changePropertiosOfModelDaily : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Dailies_AnaliseCredito_AnaliseCreditoId",
                table: "Dailies");

            migrationBuilder.DropForeignKey(
                name: "FK_Dailies_Status_StatusId",
                table: "Dailies");

            migrationBuilder.DropTable(
                name: "AnaliseCredito");

            migrationBuilder.DropTable(
                name: "Status");

            migrationBuilder.DropIndex(
                name: "IX_Dailies_AnaliseCreditoId",
                table: "Dailies");

            migrationBuilder.DropIndex(
                name: "IX_Dailies_StatusId",
                table: "Dailies");

            migrationBuilder.RenameColumn(
                name: "StatusId",
                table: "Dailies",
                newName: "Status");

            migrationBuilder.RenameColumn(
                name: "AnaliseCreditoId",
                table: "Dailies",
                newName: "AnaliseCredito");

            migrationBuilder.AddColumn<DateTime>(
                name: "DataAprovacao",
                table: "Dailies",
                type: "TEXT",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DataAprovacao",
                table: "Dailies");

            migrationBuilder.RenameColumn(
                name: "Status",
                table: "Dailies",
                newName: "StatusId");

            migrationBuilder.RenameColumn(
                name: "AnaliseCredito",
                table: "Dailies",
                newName: "AnaliseCreditoId");

            migrationBuilder.CreateTable(
                name: "AnaliseCredito",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    DataAprovacao = table.Column<DateTime>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AnaliseCredito", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Status",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nome = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Status", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Dailies_AnaliseCreditoId",
                table: "Dailies",
                column: "AnaliseCreditoId");

            migrationBuilder.CreateIndex(
                name: "IX_Dailies_StatusId",
                table: "Dailies",
                column: "StatusId");

            migrationBuilder.AddForeignKey(
                name: "FK_Dailies_AnaliseCredito_AnaliseCreditoId",
                table: "Dailies",
                column: "AnaliseCreditoId",
                principalTable: "AnaliseCredito",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Dailies_Status_StatusId",
                table: "Dailies",
                column: "StatusId",
                principalTable: "Status",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
