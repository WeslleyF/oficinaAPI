using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace OficinaAPI.Dados.Migrations
{
    /// <inheritdoc />
    public partial class createNotaServico : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "NotaServico",
                columns: table => new
                {
                    codNotaServico = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    dataCadastro = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    dataPrestacao = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    valor = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NotaServico", x => x.codNotaServico);
                });

            migrationBuilder.CreateTable(
                name: "NotaServicoItem",
                columns: table => new
                {
                    codNotaServicoItem = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    codNotaServico = table.Column<int>(type: "integer", nullable: false),
                    codServico = table.Column<int>(type: "integer", nullable: false),
                    valor = table.Column<float>(type: "real", nullable: false),
                    qtd = table.Column<float>(type: "real", nullable: false),
                    valorTotal = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NotaServicoItem", x => x.codNotaServicoItem);
                    table.ForeignKey(
                        name: "FK_NotaServicoItem_NotaServico_codNotaServico",
                        column: x => x.codNotaServico,
                        principalTable: "NotaServico",
                        principalColumn: "codNotaServico",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_NotaServicoItem_Servico_codServico",
                        column: x => x.codServico,
                        principalTable: "Servico",
                        principalColumn: "codServico",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_NotaServicoItem_codNotaServico",
                table: "NotaServicoItem",
                column: "codNotaServico");

            migrationBuilder.CreateIndex(
                name: "IX_NotaServicoItem_codServico",
                table: "NotaServicoItem",
                column: "codServico");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "NotaServicoItem");

            migrationBuilder.DropTable(
                name: "NotaServico");
        }
    }
}
