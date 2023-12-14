using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OficinaAPI.Dados.Migrations
{
    /// <inheritdoc />
    public partial class navegacao : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_cidade_estado_estadoUF",
                table: "cidade");

            migrationBuilder.RenameColumn(
                name: "estadoUF",
                table: "cidade",
                newName: "UF");

            migrationBuilder.RenameIndex(
                name: "IX_cidade_estadoUF",
                table: "cidade",
                newName: "IX_cidade_UF");

            migrationBuilder.AddForeignKey(
                name: "FK_cidade_estado_UF",
                table: "cidade",
                column: "UF",
                principalTable: "estado",
                principalColumn: "UF",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_cidade_estado_UF",
                table: "cidade");

            migrationBuilder.RenameColumn(
                name: "UF",
                table: "cidade",
                newName: "estadoUF");

            migrationBuilder.RenameIndex(
                name: "IX_cidade_UF",
                table: "cidade",
                newName: "IX_cidade_estadoUF");

            migrationBuilder.AddForeignKey(
                name: "FK_cidade_estado_estadoUF",
                table: "cidade",
                column: "estadoUF",
                principalTable: "estado",
                principalColumn: "UF",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
