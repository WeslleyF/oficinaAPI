using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OficinaAPI.Dados.Migrations
{
    /// <inheritdoc />
    public partial class ajuste_cliente_nulavel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropForeignKey(
                name: "FK_estabelecimento_bairro_bairroCodBairro",
                table: "estabelecimento");

            migrationBuilder.DropForeignKey(
                name: "FK_estabelecimento_cidade_cidadeCodCidade",
                table: "estabelecimento");

            migrationBuilder.DropForeignKey(
                name: "FK_estabelecimento_estado_estadoUF",
                table: "estabelecimento");

            migrationBuilder.DropForeignKey(
                name: "FK_funcionario_bairro_bairroCodBairro",
                table: "funcionario");

            migrationBuilder.DropForeignKey(
                name: "FK_funcionario_cidade_cidadeCodCidade",
                table: "funcionario");

            migrationBuilder.DropForeignKey(
                name: "FK_funcionario_estado_estadoUF",
                table: "funcionario");

            migrationBuilder.AlterColumn<string>(
                name: "uf",
                table: "funcionario",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "numero",
                table: "funcionario",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "estadoUF",
                table: "funcionario",
                type: "character varying(3)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "character varying(3)");

            migrationBuilder.AlterColumn<string>(
                name: "codCidade",
                table: "funcionario",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "codBairro",
                table: "funcionario",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "cidadeCodCidade",
                table: "funcionario",
                type: "character varying(150)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "character varying(150)");

            migrationBuilder.AlterColumn<string>(
                name: "bairroCodBairro",
                table: "funcionario",
                type: "character varying(200)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "character varying(200)");

            migrationBuilder.AlterColumn<string>(
                name: "Telefone",
                table: "funcionario",
                type: "character varying(20)",
                maxLength: 20,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "character varying(20)",
                oldMaxLength: 20);

            migrationBuilder.AlterColumn<string>(
                name: "RazaoSocial",
                table: "funcionario",
                type: "character varying(250)",
                maxLength: 250,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "character varying(250)",
                oldMaxLength: 250);

            migrationBuilder.AlterColumn<string>(
                name: "Logradouro",
                table: "funcionario",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "InscricaoMunicipal",
                table: "funcionario",
                type: "character varying(150)",
                maxLength: 150,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "character varying(150)",
                oldMaxLength: 150);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "funcionario",
                type: "character varying(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "character varying(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "CNPJ",
                table: "funcionario",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "CEP",
                table: "funcionario",
                type: "character varying(20)",
                maxLength: 20,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "character varying(20)",
                oldMaxLength: 20);

            migrationBuilder.AlterColumn<string>(
                name: "uf",
                table: "estabelecimento",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "numero",
                table: "estabelecimento",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "estadoUF",
                table: "estabelecimento",
                type: "character varying(3)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "character varying(3)");

            migrationBuilder.AlterColumn<string>(
                name: "codCidade",
                table: "estabelecimento",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "codBairro",
                table: "estabelecimento",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "cidadeCodCidade",
                table: "estabelecimento",
                type: "character varying(150)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "character varying(150)");

            migrationBuilder.AlterColumn<string>(
                name: "bairroCodBairro",
                table: "estabelecimento",
                type: "character varying(200)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "character varying(200)");

            migrationBuilder.AlterColumn<string>(
                name: "Telefone",
                table: "estabelecimento",
                type: "character varying(20)",
                maxLength: 20,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "character varying(20)",
                oldMaxLength: 20);

            migrationBuilder.AlterColumn<string>(
                name: "RazaoSocial",
                table: "estabelecimento",
                type: "character varying(250)",
                maxLength: 250,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "character varying(250)",
                oldMaxLength: 250);

            migrationBuilder.AlterColumn<string>(
                name: "Logradouro",
                table: "estabelecimento",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "InscricaoMunicipal",
                table: "estabelecimento",
                type: "character varying(150)",
                maxLength: 150,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "character varying(150)",
                oldMaxLength: 150);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "estabelecimento",
                type: "character varying(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "character varying(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "CNPJ",
                table: "estabelecimento",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "CEP",
                table: "estabelecimento",
                type: "character varying(20)",
                maxLength: 20,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "character varying(20)",
                oldMaxLength: 20);

            migrationBuilder.AlterColumn<string>(
                name: "uf",
                table: "cliente",
                type: "character varying(3)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "character varying(3)");

            migrationBuilder.AlterColumn<string>(
                name: "numero",
                table: "cliente",
                type: "character varying(10)",
                maxLength: 10,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "character varying(10)",
                oldMaxLength: 10);

            migrationBuilder.AlterColumn<string>(
                name: "codCidade",
                table: "cliente",
                type: "character varying(150)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "character varying(150)");

            migrationBuilder.AlterColumn<string>(
                name: "codBairro",
                table: "cliente",
                type: "character varying(200)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "character varying(200)");

            migrationBuilder.AlterColumn<string>(
                name: "Telefone",
                table: "cliente",
                type: "character varying(20)",
                maxLength: 20,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "character varying(20)",
                oldMaxLength: 20);

            migrationBuilder.AlterColumn<string>(
                name: "RazaoSocial",
                table: "cliente",
                type: "character varying(250)",
                maxLength: 250,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "character varying(250)",
                oldMaxLength: 250);

            migrationBuilder.AlterColumn<string>(
                name: "Logradouro",
                table: "cliente",
                type: "character varying(200)",
                maxLength: 200,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "InscricaoMunicipal",
                table: "cliente",
                type: "character varying(150)",
                maxLength: 150,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "character varying(150)",
                oldMaxLength: 150);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "cliente",
                type: "character varying(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "character varying(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "CPF",
                table: "cliente",
                type: "character varying(20)",
                maxLength: 20,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "character varying(20)",
                oldMaxLength: 20);

            migrationBuilder.AlterColumn<string>(
                name: "CNPJ",
                table: "cliente",
                type: "character varying(20)",
                maxLength: 20,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "character varying(20)",
                oldMaxLength: 20);

            migrationBuilder.AlterColumn<string>(
                name: "CEP",
                table: "cliente",
                type: "character varying(20)",
                maxLength: 20,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "character varying(20)",
                oldMaxLength: 20);

            migrationBuilder.AddForeignKey(
                name: "FK_cliente_bairro_codBairro",
                table: "cliente",
                column: "codBairro",
                principalTable: "bairro",
                principalColumn: "CodBairro");

            migrationBuilder.AddForeignKey(
                name: "FK_cliente_cidade_codCidade",
                table: "cliente",
                column: "codCidade",
                principalTable: "cidade",
                principalColumn: "CodCidade");

            migrationBuilder.AddForeignKey(
                name: "FK_cliente_estado_uf",
                table: "cliente",
                column: "uf",
                principalTable: "estado",
                principalColumn: "UF");

            migrationBuilder.AddForeignKey(
                name: "FK_estabelecimento_bairro_bairroCodBairro",
                table: "estabelecimento",
                column: "bairroCodBairro",
                principalTable: "bairro",
                principalColumn: "CodBairro");

            migrationBuilder.AddForeignKey(
                name: "FK_estabelecimento_cidade_cidadeCodCidade",
                table: "estabelecimento",
                column: "cidadeCodCidade",
                principalTable: "cidade",
                principalColumn: "CodCidade");

            migrationBuilder.AddForeignKey(
                name: "FK_estabelecimento_estado_estadoUF",
                table: "estabelecimento",
                column: "estadoUF",
                principalTable: "estado",
                principalColumn: "UF");

            migrationBuilder.AddForeignKey(
                name: "FK_funcionario_bairro_bairroCodBairro",
                table: "funcionario",
                column: "bairroCodBairro",
                principalTable: "bairro",
                principalColumn: "CodBairro");

            migrationBuilder.AddForeignKey(
                name: "FK_funcionario_cidade_cidadeCodCidade",
                table: "funcionario",
                column: "cidadeCodCidade",
                principalTable: "cidade",
                principalColumn: "CodCidade");

            migrationBuilder.AddForeignKey(
                name: "FK_funcionario_estado_estadoUF",
                table: "funcionario",
                column: "estadoUF",
                principalTable: "estado",
                principalColumn: "UF");
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

            migrationBuilder.DropForeignKey(
                name: "FK_estabelecimento_bairro_bairroCodBairro",
                table: "estabelecimento");

            migrationBuilder.DropForeignKey(
                name: "FK_estabelecimento_cidade_cidadeCodCidade",
                table: "estabelecimento");

            migrationBuilder.DropForeignKey(
                name: "FK_estabelecimento_estado_estadoUF",
                table: "estabelecimento");

            migrationBuilder.DropForeignKey(
                name: "FK_funcionario_bairro_bairroCodBairro",
                table: "funcionario");

            migrationBuilder.DropForeignKey(
                name: "FK_funcionario_cidade_cidadeCodCidade",
                table: "funcionario");

            migrationBuilder.DropForeignKey(
                name: "FK_funcionario_estado_estadoUF",
                table: "funcionario");

            migrationBuilder.AlterColumn<string>(
                name: "uf",
                table: "funcionario",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "numero",
                table: "funcionario",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "estadoUF",
                table: "funcionario",
                type: "character varying(3)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "character varying(3)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "codCidade",
                table: "funcionario",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "codBairro",
                table: "funcionario",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "cidadeCodCidade",
                table: "funcionario",
                type: "character varying(150)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "character varying(150)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "bairroCodBairro",
                table: "funcionario",
                type: "character varying(200)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "character varying(200)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Telefone",
                table: "funcionario",
                type: "character varying(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "character varying(20)",
                oldMaxLength: 20,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "RazaoSocial",
                table: "funcionario",
                type: "character varying(250)",
                maxLength: 250,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "character varying(250)",
                oldMaxLength: 250,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Logradouro",
                table: "funcionario",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "InscricaoMunicipal",
                table: "funcionario",
                type: "character varying(150)",
                maxLength: 150,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "character varying(150)",
                oldMaxLength: 150,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "funcionario",
                type: "character varying(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "character varying(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CNPJ",
                table: "funcionario",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CEP",
                table: "funcionario",
                type: "character varying(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "character varying(20)",
                oldMaxLength: 20,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "uf",
                table: "estabelecimento",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "numero",
                table: "estabelecimento",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "estadoUF",
                table: "estabelecimento",
                type: "character varying(3)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "character varying(3)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "codCidade",
                table: "estabelecimento",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "codBairro",
                table: "estabelecimento",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "cidadeCodCidade",
                table: "estabelecimento",
                type: "character varying(150)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "character varying(150)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "bairroCodBairro",
                table: "estabelecimento",
                type: "character varying(200)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "character varying(200)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Telefone",
                table: "estabelecimento",
                type: "character varying(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "character varying(20)",
                oldMaxLength: 20,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "RazaoSocial",
                table: "estabelecimento",
                type: "character varying(250)",
                maxLength: 250,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "character varying(250)",
                oldMaxLength: 250,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Logradouro",
                table: "estabelecimento",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "InscricaoMunicipal",
                table: "estabelecimento",
                type: "character varying(150)",
                maxLength: 150,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "character varying(150)",
                oldMaxLength: 150,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "estabelecimento",
                type: "character varying(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "character varying(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CNPJ",
                table: "estabelecimento",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CEP",
                table: "estabelecimento",
                type: "character varying(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "character varying(20)",
                oldMaxLength: 20,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "uf",
                table: "cliente",
                type: "character varying(3)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "character varying(3)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "numero",
                table: "cliente",
                type: "character varying(10)",
                maxLength: 10,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "character varying(10)",
                oldMaxLength: 10,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "codCidade",
                table: "cliente",
                type: "character varying(150)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "character varying(150)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "codBairro",
                table: "cliente",
                type: "character varying(200)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "character varying(200)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Telefone",
                table: "cliente",
                type: "character varying(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "character varying(20)",
                oldMaxLength: 20,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "RazaoSocial",
                table: "cliente",
                type: "character varying(250)",
                maxLength: 250,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "character varying(250)",
                oldMaxLength: 250,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Logradouro",
                table: "cliente",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "character varying(200)",
                oldMaxLength: 200,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "InscricaoMunicipal",
                table: "cliente",
                type: "character varying(150)",
                maxLength: 150,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "character varying(150)",
                oldMaxLength: 150,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "cliente",
                type: "character varying(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "character varying(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CPF",
                table: "cliente",
                type: "character varying(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "character varying(20)",
                oldMaxLength: 20,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CNPJ",
                table: "cliente",
                type: "character varying(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "character varying(20)",
                oldMaxLength: 20,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CEP",
                table: "cliente",
                type: "character varying(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "character varying(20)",
                oldMaxLength: 20,
                oldNullable: true);

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

            migrationBuilder.AddForeignKey(
                name: "FK_estabelecimento_bairro_bairroCodBairro",
                table: "estabelecimento",
                column: "bairroCodBairro",
                principalTable: "bairro",
                principalColumn: "CodBairro",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_estabelecimento_cidade_cidadeCodCidade",
                table: "estabelecimento",
                column: "cidadeCodCidade",
                principalTable: "cidade",
                principalColumn: "CodCidade",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_estabelecimento_estado_estadoUF",
                table: "estabelecimento",
                column: "estadoUF",
                principalTable: "estado",
                principalColumn: "UF",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_funcionario_bairro_bairroCodBairro",
                table: "funcionario",
                column: "bairroCodBairro",
                principalTable: "bairro",
                principalColumn: "CodBairro",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_funcionario_cidade_cidadeCodCidade",
                table: "funcionario",
                column: "cidadeCodCidade",
                principalTable: "cidade",
                principalColumn: "CodCidade",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_funcionario_estado_estadoUF",
                table: "funcionario",
                column: "estadoUF",
                principalTable: "estado",
                principalColumn: "UF",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
