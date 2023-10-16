using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DailyManagment.Migrations
{
    /// <inheritdoc />
    public partial class CreateTableDailies : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Dailies",
                columns: table => new
                {
                    id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Produto = table.Column<string>(type: "TEXT", nullable: false),
                    Segmento = table.Column<string>(type: "TEXT", nullable: true),
                    Tipo = table.Column<string>(type: "TEXT", nullable: true),
                    Cliente = table.Column<string>(type: "TEXT", nullable: true),
                    Rev = table.Column<string>(type: "TEXT", nullable: true),
                    DataDefinicao = table.Column<DateTime>(type: "TEXT", nullable: true),
                    DataEntregaPrevista = table.Column<DateTime>(type: "TEXT", nullable: true),
                    DataEntregaReal = table.Column<DateTime>(type: "TEXT", nullable: true),
                    Projeto_Aplicacao = table.Column<string>(type: "TEXT", nullable: true),
                    Responsavel = table.Column<string>(type: "TEXT", nullable: true),
                    CRM = table.Column<string>(type: "TEXT", nullable: true),
                    Status = table.Column<string>(type: "TEXT", nullable: true),
                    AnaliseCredito = table.Column<string>(type: "TEXT", nullable: true),
                    DataAprovacao = table.Column<DateTime>(type: "TEXT", nullable: true),
                    Pendencia = table.Column<string>(type: "TEXT", nullable: true),
                    PV = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dailies", x => x.id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Dailies");
        }
    }
}
