using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OficinaAPI.Dados.Migrations
{
    /// <inheritdoc />
    public partial class ajuste_cliente : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_cliente_bairro_bairroCodBairro",
                table: "cliente");

            migrationBuilder.DropForeignKey(
                name: "FK_cliente_cidade_cidadeCodCidade",
                table: "cliente");

            migrationBuilder.DropForeignKey(
                name: "FK_cliente_estado_estadoUF",
                table: "cliente");

            migrationBuilder.RenameColumn(
                name: "estadoUF",
                table: "cliente",
                newName: "uf");

            migrationBuilder.RenameColumn(
                name: "cidadeCodCidade",
                table: "cliente",
                newName: "codCidade");

            migrationBuilder.RenameColumn(
                name: "bairroCodBairro",
                table: "cliente",
                newName: "codBairro");

            migrationBuilder.RenameIndex(
                name: "IX_cliente_estadoUF",
                table: "cliente",
                newName: "IX_cliente_uf");

            migrationBuilder.RenameIndex(
                name: "IX_cliente_cidadeCodCidade",
                table: "cliente",
                newName: "IX_cliente_codCidade");

            migrationBuilder.RenameIndex(
                name: "IX_cliente_bairroCodBairro",
                table: "cliente",
                newName: "IX_cliente_codBairro");

            migrationBuilder.AddColumn<string>(
                name: "codBairro",
                table: "funcionario",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "codCidade",
                table: "funcionario",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "uf",
                table: "funcionario",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "codBairro",
                table: "estabelecimento",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "codCidade",
                table: "estabelecimento",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "uf",
                table: "estabelecimento",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddForeignKey(
                name: "FK_cliente_bairro_codBairro",
                table: "cliente",
                column: "codBairro",
                principalTable: "bairro",
                principalColumn: "CodBairro",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_cliente_cidade_codCidade",
                table: "cliente",
                column: "codCidade",
                principalTable: "cidade",
                principalColumn: "CodCidade",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_cliente_estado_uf",
                table: "cliente",
                column: "uf",
                principalTable: "estado",
                principalColumn: "UF",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_cliente_bairro_codBairro",
                table: "cliente");

            migrationBuilder.DropForeignKey(
                name: "FK_cliente_cidade_codCidade",
                table: "cliente");

            migrationBuilder.DropForeignKey(
                name: "FK_cliente_estado_uf",
                table: "cliente");

            migrationBuilder.DropColumn(
                name: "codBairro",
                table: "funcionario");

            migrationBuilder.DropColumn(
                name: "codCidade",
                table: "funcionario");

            migrationBuilder.DropColumn(
                name: "uf",
                table: "funcionario");

            migrationBuilder.DropColumn(
                name: "codBairro",
                table: "estabelecimento");

            migrationBuilder.DropColumn(
                name: "codCidade",
                table: "estabelecimento");

            migrationBuilder.DropColumn(
                name: "uf",
                table: "estabelecimento");

            migrationBuilder.RenameColumn(
                name: "uf",
                table: "cliente",
                newName: "estadoUF");

            migrationBuilder.RenameColumn(
                name: "codCidade",
                table: "cliente",
                newName: "cidadeCodCidade");

            migrationBuilder.RenameColumn(
                name: "codBairro",
                table: "cliente",
                newName: "bairroCodBairro");

            migrationBuilder.RenameIndex(
                name: "IX_cliente_uf",
                table: "cliente",
                newName: "IX_cliente_estadoUF");

            migrationBuilder.RenameIndex(
                name: "IX_cliente_codCidade",
                table: "cliente",
                newName: "IX_cliente_cidadeCodCidade");

            migrationBuilder.RenameIndex(
                name: "IX_cliente_codBairro",
                table: "cliente",
                newName: "IX_cliente_bairroCodBairro");

            migrationBuilder.AddForeignKey(
                name: "FK_cliente_bairro_bairroCodBairro",
                table: "cliente",
                column: "bairroCodBairro",
                principalTable: "bairro",
                principalColumn: "CodBairro",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_cliente_cidade_cidadeCodCidade",
                table: "cliente",
                column: "cidadeCodCidade",
                principalTable: "cidade",
                principalColumn: "CodCidade",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_cliente_estado_estadoUF",
                table: "cliente",
                column: "estadoUF",
                principalTable: "estado",
                principalColumn: "UF",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
