using Microsoft.EntityFrameworkCore.Migrations;

namespace Oficina.Dados.Migrations
{
    public partial class Pessoa_Remocao_Campo_Cod_Bairro_Cidade_UF : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CodBairro",
                table: "funcionario");

            migrationBuilder.DropColumn(
                name: "CodCidade",
                table: "funcionario");

            migrationBuilder.DropColumn(
                name: "UF",
                table: "funcionario");

            migrationBuilder.DropColumn(
                name: "CodBairro",
                table: "estabelecimento");

            migrationBuilder.DropColumn(
                name: "CodCidade",
                table: "estabelecimento");

            migrationBuilder.DropColumn(
                name: "UF",
                table: "estabelecimento");

            migrationBuilder.DropColumn(
                name: "CodBairro",
                table: "cliente");

            migrationBuilder.DropColumn(
                name: "CodCidade",
                table: "cliente");

            migrationBuilder.DropColumn(
                name: "UF",
                table: "cliente");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CodBairro",
                table: "funcionario",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CodCidade",
                table: "funcionario",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UF",
                table: "funcionario",
                type: "character varying(3)",
                maxLength: 3,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CodBairro",
                table: "estabelecimento",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CodCidade",
                table: "estabelecimento",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UF",
                table: "estabelecimento",
                type: "character varying(3)",
                maxLength: 3,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CodBairro",
                table: "cliente",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CodCidade",
                table: "cliente",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UF",
                table: "cliente",
                type: "character varying(3)",
                maxLength: 3,
                nullable: true);
        }
    }
}
