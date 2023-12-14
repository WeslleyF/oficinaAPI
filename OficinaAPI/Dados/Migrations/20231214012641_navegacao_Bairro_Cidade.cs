using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OficinaAPI.Dados.Migrations
{
    /// <inheritdoc />
    public partial class navegacao_Bairro_Cidade : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_bairro_cidade_cidadeCodCidade",
                table: "bairro");

            migrationBuilder.RenameColumn(
                name: "cidadeCodCidade",
                table: "bairro",
                newName: "CodCidade");

            migrationBuilder.RenameIndex(
                name: "IX_bairro_cidadeCodCidade",
                table: "bairro",
                newName: "IX_bairro_CodCidade");

            migrationBuilder.AddForeignKey(
                name: "FK_bairro_cidade_CodCidade",
                table: "bairro",
                column: "CodCidade",
                principalTable: "cidade",
                principalColumn: "CodCidade",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_bairro_cidade_CodCidade",
                table: "bairro");

            migrationBuilder.RenameColumn(
                name: "CodCidade",
                table: "bairro",
                newName: "cidadeCodCidade");

            migrationBuilder.RenameIndex(
                name: "IX_bairro_CodCidade",
                table: "bairro",
                newName: "IX_bairro_cidadeCodCidade");

            migrationBuilder.AddForeignKey(
                name: "FK_bairro_cidade_cidadeCodCidade",
                table: "bairro",
                column: "cidadeCodCidade",
                principalTable: "cidade",
                principalColumn: "CodCidade",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
