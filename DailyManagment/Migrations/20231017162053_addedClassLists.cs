using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DailyManagment.Migrations
{
    /// <inheritdoc />
    public partial class addedClassLists : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AnaliseCredito",
                table: "Dailies");

            migrationBuilder.DropColumn(
                name: "DataAprovacao",
                table: "Dailies");

            migrationBuilder.DropColumn(
                name: "Produto",
                table: "Dailies");

            migrationBuilder.DropColumn(
                name: "Responsavel",
                table: "Dailies");

            migrationBuilder.DropColumn(
                name: "Segmento",
                table: "Dailies");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "Dailies");

            migrationBuilder.DropColumn(
                name: "Tipo",
                table: "Dailies");

            migrationBuilder.AddColumn<int>(
                name: "AnaliseCreditoId",
                table: "Dailies",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ProdutoId",
                table: "Dailies",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ResponsavelId",
                table: "Dailies",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SegmentoId",
                table: "Dailies",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "StatusId",
                table: "Dailies",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TipoId",
                table: "Dailies",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

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
                name: "Produto",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nome = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Produto", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Responsavel",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nome = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Responsavel", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Segmento",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nome = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Segmento", x => x.Id);
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

            migrationBuilder.CreateTable(
                name: "Tipo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nome = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tipo", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Dailies_AnaliseCreditoId",
                table: "Dailies",
                column: "AnaliseCreditoId");

            migrationBuilder.CreateIndex(
                name: "IX_Dailies_ProdutoId",
                table: "Dailies",
                column: "ProdutoId");

            migrationBuilder.CreateIndex(
                name: "IX_Dailies_ResponsavelId",
                table: "Dailies",
                column: "ResponsavelId");

            migrationBuilder.CreateIndex(
                name: "IX_Dailies_SegmentoId",
                table: "Dailies",
                column: "SegmentoId");

            migrationBuilder.CreateIndex(
                name: "IX_Dailies_StatusId",
                table: "Dailies",
                column: "StatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Dailies_TipoId",
                table: "Dailies",
                column: "TipoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Dailies_AnaliseCredito_AnaliseCreditoId",
                table: "Dailies",
                column: "AnaliseCreditoId",
                principalTable: "AnaliseCredito",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Dailies_Produto_ProdutoId",
                table: "Dailies",
                column: "ProdutoId",
                principalTable: "Produto",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Dailies_Responsavel_ResponsavelId",
                table: "Dailies",
                column: "ResponsavelId",
                principalTable: "Responsavel",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Dailies_Segmento_SegmentoId",
                table: "Dailies",
                column: "SegmentoId",
                principalTable: "Segmento",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Dailies_Status_StatusId",
                table: "Dailies",
                column: "StatusId",
                principalTable: "Status",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Dailies_Tipo_TipoId",
                table: "Dailies",
                column: "TipoId",
                principalTable: "Tipo",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Dailies_AnaliseCredito_AnaliseCreditoId",
                table: "Dailies");

            migrationBuilder.DropForeignKey(
                name: "FK_Dailies_Produto_ProdutoId",
                table: "Dailies");

            migrationBuilder.DropForeignKey(
                name: "FK_Dailies_Responsavel_ResponsavelId",
                table: "Dailies");

            migrationBuilder.DropForeignKey(
                name: "FK_Dailies_Segmento_SegmentoId",
                table: "Dailies");

            migrationBuilder.DropForeignKey(
                name: "FK_Dailies_Status_StatusId",
                table: "Dailies");

            migrationBuilder.DropForeignKey(
                name: "FK_Dailies_Tipo_TipoId",
                table: "Dailies");

            migrationBuilder.DropTable(
                name: "AnaliseCredito");

            migrationBuilder.DropTable(
                name: "Produto");

            migrationBuilder.DropTable(
                name: "Responsavel");

            migrationBuilder.DropTable(
                name: "Segmento");

            migrationBuilder.DropTable(
                name: "Status");

            migrationBuilder.DropTable(
                name: "Tipo");

            migrationBuilder.DropIndex(
                name: "IX_Dailies_AnaliseCreditoId",
                table: "Dailies");

            migrationBuilder.DropIndex(
                name: "IX_Dailies_ProdutoId",
                table: "Dailies");

            migrationBuilder.DropIndex(
                name: "IX_Dailies_ResponsavelId",
                table: "Dailies");

            migrationBuilder.DropIndex(
                name: "IX_Dailies_SegmentoId",
                table: "Dailies");

            migrationBuilder.DropIndex(
                name: "IX_Dailies_StatusId",
                table: "Dailies");

            migrationBuilder.DropIndex(
                name: "IX_Dailies_TipoId",
                table: "Dailies");

            migrationBuilder.DropColumn(
                name: "AnaliseCreditoId",
                table: "Dailies");

            migrationBuilder.DropColumn(
                name: "ProdutoId",
                table: "Dailies");

            migrationBuilder.DropColumn(
                name: "ResponsavelId",
                table: "Dailies");

            migrationBuilder.DropColumn(
                name: "SegmentoId",
                table: "Dailies");

            migrationBuilder.DropColumn(
                name: "StatusId",
                table: "Dailies");

            migrationBuilder.DropColumn(
                name: "TipoId",
                table: "Dailies");

            migrationBuilder.AddColumn<string>(
                name: "AnaliseCredito",
                table: "Dailies",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DataAprovacao",
                table: "Dailies",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Produto",
                table: "Dailies",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Responsavel",
                table: "Dailies",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Segmento",
                table: "Dailies",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Status",
                table: "Dailies",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Tipo",
                table: "Dailies",
                type: "TEXT",
                nullable: true);
        }
    }
}
