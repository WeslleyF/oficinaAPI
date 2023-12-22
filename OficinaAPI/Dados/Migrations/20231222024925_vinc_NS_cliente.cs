using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OficinaAPI.Dados.Migrations
{
    /// <inheritdoc />
    public partial class vinc_NS_cliente : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_NotaServicoItem_NotaServico_codNotaServico",
                table: "NotaServicoItem");

            migrationBuilder.DropForeignKey(
                name: "FK_NotaServicoItem_Servico_codServico",
                table: "NotaServicoItem");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Servico",
                table: "Servico");

            migrationBuilder.DropPrimaryKey(
                name: "PK_NotaServicoItem",
                table: "NotaServicoItem");

            migrationBuilder.DropPrimaryKey(
                name: "PK_NotaServico",
                table: "NotaServico");

            migrationBuilder.RenameTable(
                name: "Servico",
                newName: "servico");

            migrationBuilder.RenameTable(
                name: "NotaServicoItem",
                newName: "notaServicoItem");

            migrationBuilder.RenameTable(
                name: "NotaServico",
                newName: "notaServico");

            migrationBuilder.RenameIndex(
                name: "IX_NotaServicoItem_codServico",
                table: "notaServicoItem",
                newName: "IX_notaServicoItem_codServico");

            migrationBuilder.RenameIndex(
                name: "IX_NotaServicoItem_codNotaServico",
                table: "notaServicoItem",
                newName: "IX_notaServicoItem_codNotaServico");

            migrationBuilder.AddColumn<int>(
                name: "codCliente",
                table: "notaServico",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_servico",
                table: "servico",
                column: "codServico");

            migrationBuilder.AddPrimaryKey(
                name: "PK_notaServicoItem",
                table: "notaServicoItem",
                column: "codNotaServicoItem");

            migrationBuilder.AddPrimaryKey(
                name: "PK_notaServico",
                table: "notaServico",
                column: "codNotaServico");

            migrationBuilder.CreateIndex(
                name: "IX_notaServico_codCliente",
                table: "notaServico",
                column: "codCliente");

            migrationBuilder.AddForeignKey(
                name: "FK_notaServico_cliente_codCliente",
                table: "notaServico",
                column: "codCliente",
                principalTable: "cliente",
                principalColumn: "CodCliente",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_notaServicoItem_notaServico_codNotaServico",
                table: "notaServicoItem",
                column: "codNotaServico",
                principalTable: "notaServico",
                principalColumn: "codNotaServico",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_notaServicoItem_servico_codServico",
                table: "notaServicoItem",
                column: "codServico",
                principalTable: "servico",
                principalColumn: "codServico",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_notaServico_cliente_codCliente",
                table: "notaServico");

            migrationBuilder.DropForeignKey(
                name: "FK_notaServicoItem_notaServico_codNotaServico",
                table: "notaServicoItem");

            migrationBuilder.DropForeignKey(
                name: "FK_notaServicoItem_servico_codServico",
                table: "notaServicoItem");

            migrationBuilder.DropPrimaryKey(
                name: "PK_servico",
                table: "servico");

            migrationBuilder.DropPrimaryKey(
                name: "PK_notaServicoItem",
                table: "notaServicoItem");

            migrationBuilder.DropPrimaryKey(
                name: "PK_notaServico",
                table: "notaServico");

            migrationBuilder.DropIndex(
                name: "IX_notaServico_codCliente",
                table: "notaServico");

            migrationBuilder.DropColumn(
                name: "codCliente",
                table: "notaServico");

            migrationBuilder.RenameTable(
                name: "servico",
                newName: "Servico");

            migrationBuilder.RenameTable(
                name: "notaServicoItem",
                newName: "NotaServicoItem");

            migrationBuilder.RenameTable(
                name: "notaServico",
                newName: "NotaServico");

            migrationBuilder.RenameIndex(
                name: "IX_notaServicoItem_codServico",
                table: "NotaServicoItem",
                newName: "IX_NotaServicoItem_codServico");

            migrationBuilder.RenameIndex(
                name: "IX_notaServicoItem_codNotaServico",
                table: "NotaServicoItem",
                newName: "IX_NotaServicoItem_codNotaServico");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Servico",
                table: "Servico",
                column: "codServico");

            migrationBuilder.AddPrimaryKey(
                name: "PK_NotaServicoItem",
                table: "NotaServicoItem",
                column: "codNotaServicoItem");

            migrationBuilder.AddPrimaryKey(
                name: "PK_NotaServico",
                table: "NotaServico",
                column: "codNotaServico");

            migrationBuilder.AddForeignKey(
                name: "FK_NotaServicoItem_NotaServico_codNotaServico",
                table: "NotaServicoItem",
                column: "codNotaServico",
                principalTable: "NotaServico",
                principalColumn: "codNotaServico",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_NotaServicoItem_Servico_codServico",
                table: "NotaServicoItem",
                column: "codServico",
                principalTable: "Servico",
                principalColumn: "codServico",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
