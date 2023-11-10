using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Oficina.Dados.Migrations
{
    /// <inheritdoc />
    public partial class remocao_endereco : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_bairro_cidade_cidadeCodCidade",
                table: "bairro");

            migrationBuilder.DropForeignKey(
                name: "FK_cidade_estado_estadoUF",
                table: "cidade");

            migrationBuilder.DropForeignKey(
                name: "FK_estabelecimento_endereco_enderecoCodCliente",
                table: "estabelecimento");

            migrationBuilder.DropForeignKey(
                name: "FK_funcionario_endereco_enderecoCodCliente",
                table: "funcionario");

            migrationBuilder.DropTable(
                name: "endereco");

            migrationBuilder.DropIndex(
                name: "IX_funcionario_enderecoCodCliente",
                table: "funcionario");

            migrationBuilder.DropIndex(
                name: "IX_estabelecimento_enderecoCodCliente",
                table: "estabelecimento");

            migrationBuilder.DropColumn(
                name: "enderecoCodCliente",
                table: "funcionario");

            migrationBuilder.DropColumn(
                name: "enderecoCodCliente",
                table: "estabelecimento");

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
                name: "Nome",
                table: "funcionario",
                type: "character varying(300)",
                maxLength: 300,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "character varying(300)",
                oldMaxLength: 300,
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

            migrationBuilder.AddColumn<string>(
                name: "Logradouro",
                table: "funcionario",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "bairroCodBairro",
                table: "funcionario",
                type: "character varying(200)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "cidadeCodCidade",
                table: "funcionario",
                type: "character varying(150)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "estadoUF",
                table: "funcionario",
                type: "character varying(3)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "numero",
                table: "funcionario",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "Descricao",
                table: "estado",
                type: "character varying(250)",
                maxLength: 250,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "character varying(250)",
                oldMaxLength: 250,
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
                name: "NomeEstabelecimento",
                table: "estabelecimento",
                type: "character varying(300)",
                maxLength: 300,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "character varying(300)",
                oldMaxLength: 300,
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

            migrationBuilder.AddColumn<string>(
                name: "Logradouro",
                table: "estabelecimento",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "bairroCodBairro",
                table: "estabelecimento",
                type: "character varying(200)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "cidadeCodCidade",
                table: "estabelecimento",
                type: "character varying(150)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "estadoUF",
                table: "estabelecimento",
                type: "character varying(3)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "numero",
                table: "estabelecimento",
                type: "text",
                nullable: false,
                defaultValue: "");

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
                name: "Nome",
                table: "cliente",
                type: "character varying(300)",
                maxLength: 300,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "character varying(300)",
                oldMaxLength: 300,
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
                name: "CNPJ",
                table: "cliente",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
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

            migrationBuilder.AddColumn<string>(
                name: "Logradouro",
                table: "cliente",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "bairroCodBairro",
                table: "cliente",
                type: "character varying(200)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "cidadeCodCidade",
                table: "cliente",
                type: "character varying(150)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "estadoUF",
                table: "cliente",
                type: "character varying(3)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "numero",
                table: "cliente",
                type: "character varying(10)",
                maxLength: 10,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "estadoUF",
                table: "cidade",
                type: "character varying(3)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "character varying(3)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Descricao",
                table: "cidade",
                type: "character varying(500)",
                maxLength: 500,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "character varying(500)",
                oldMaxLength: 500,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "cidadeCodCidade",
                table: "bairro",
                type: "character varying(150)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "character varying(150)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Descricao",
                table: "bairro",
                type: "character varying(500)",
                maxLength: 500,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "character varying(500)",
                oldMaxLength: 500,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CodCidade",
                table: "bairro",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_funcionario_bairroCodBairro",
                table: "funcionario",
                column: "bairroCodBairro");

            migrationBuilder.CreateIndex(
                name: "IX_funcionario_cidadeCodCidade",
                table: "funcionario",
                column: "cidadeCodCidade");

            migrationBuilder.CreateIndex(
                name: "IX_funcionario_estadoUF",
                table: "funcionario",
                column: "estadoUF");

            migrationBuilder.CreateIndex(
                name: "IX_estabelecimento_bairroCodBairro",
                table: "estabelecimento",
                column: "bairroCodBairro");

            migrationBuilder.CreateIndex(
                name: "IX_estabelecimento_cidadeCodCidade",
                table: "estabelecimento",
                column: "cidadeCodCidade");

            migrationBuilder.CreateIndex(
                name: "IX_estabelecimento_estadoUF",
                table: "estabelecimento",
                column: "estadoUF");

            migrationBuilder.CreateIndex(
                name: "IX_cliente_bairroCodBairro",
                table: "cliente",
                column: "bairroCodBairro");

            migrationBuilder.CreateIndex(
                name: "IX_cliente_cidadeCodCidade",
                table: "cliente",
                column: "cidadeCodCidade");

            migrationBuilder.CreateIndex(
                name: "IX_cliente_estadoUF",
                table: "cliente",
                column: "estadoUF");

            migrationBuilder.AddForeignKey(
                name: "FK_bairro_cidade_cidadeCodCidade",
                table: "bairro",
                column: "cidadeCodCidade",
                principalTable: "cidade",
                principalColumn: "CodCidade",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_cidade_estado_estadoUF",
                table: "cidade",
                column: "estadoUF",
                principalTable: "estado",
                principalColumn: "UF",
                onDelete: ReferentialAction.Cascade);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_bairro_cidade_cidadeCodCidade",
                table: "bairro");

            migrationBuilder.DropForeignKey(
                name: "FK_cidade_estado_estadoUF",
                table: "cidade");

            migrationBuilder.DropForeignKey(
                name: "FK_cliente_bairro_bairroCodBairro",
                table: "cliente");

            migrationBuilder.DropForeignKey(
                name: "FK_cliente_cidade_cidadeCodCidade",
                table: "cliente");

            migrationBuilder.DropForeignKey(
                name: "FK_cliente_estado_estadoUF",
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

            migrationBuilder.DropIndex(
                name: "IX_funcionario_bairroCodBairro",
                table: "funcionario");

            migrationBuilder.DropIndex(
                name: "IX_funcionario_cidadeCodCidade",
                table: "funcionario");

            migrationBuilder.DropIndex(
                name: "IX_funcionario_estadoUF",
                table: "funcionario");

            migrationBuilder.DropIndex(
                name: "IX_estabelecimento_bairroCodBairro",
                table: "estabelecimento");

            migrationBuilder.DropIndex(
                name: "IX_estabelecimento_cidadeCodCidade",
                table: "estabelecimento");

            migrationBuilder.DropIndex(
                name: "IX_estabelecimento_estadoUF",
                table: "estabelecimento");

            migrationBuilder.DropIndex(
                name: "IX_cliente_bairroCodBairro",
                table: "cliente");

            migrationBuilder.DropIndex(
                name: "IX_cliente_cidadeCodCidade",
                table: "cliente");

            migrationBuilder.DropIndex(
                name: "IX_cliente_estadoUF",
                table: "cliente");

            migrationBuilder.DropColumn(
                name: "Logradouro",
                table: "funcionario");

            migrationBuilder.DropColumn(
                name: "bairroCodBairro",
                table: "funcionario");

            migrationBuilder.DropColumn(
                name: "cidadeCodCidade",
                table: "funcionario");

            migrationBuilder.DropColumn(
                name: "estadoUF",
                table: "funcionario");

            migrationBuilder.DropColumn(
                name: "numero",
                table: "funcionario");

            migrationBuilder.DropColumn(
                name: "Logradouro",
                table: "estabelecimento");

            migrationBuilder.DropColumn(
                name: "bairroCodBairro",
                table: "estabelecimento");

            migrationBuilder.DropColumn(
                name: "cidadeCodCidade",
                table: "estabelecimento");

            migrationBuilder.DropColumn(
                name: "estadoUF",
                table: "estabelecimento");

            migrationBuilder.DropColumn(
                name: "numero",
                table: "estabelecimento");

            migrationBuilder.DropColumn(
                name: "Logradouro",
                table: "cliente");

            migrationBuilder.DropColumn(
                name: "bairroCodBairro",
                table: "cliente");

            migrationBuilder.DropColumn(
                name: "cidadeCodCidade",
                table: "cliente");

            migrationBuilder.DropColumn(
                name: "estadoUF",
                table: "cliente");

            migrationBuilder.DropColumn(
                name: "numero",
                table: "cliente");

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
                name: "Nome",
                table: "funcionario",
                type: "character varying(300)",
                maxLength: 300,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "character varying(300)",
                oldMaxLength: 300);

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

            migrationBuilder.AddColumn<int>(
                name: "enderecoCodCliente",
                table: "funcionario",
                type: "integer",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Descricao",
                table: "estado",
                type: "character varying(250)",
                maxLength: 250,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "character varying(250)",
                oldMaxLength: 250);

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
                name: "NomeEstabelecimento",
                table: "estabelecimento",
                type: "character varying(300)",
                maxLength: 300,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "character varying(300)",
                oldMaxLength: 300);

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

            migrationBuilder.AddColumn<int>(
                name: "enderecoCodCliente",
                table: "estabelecimento",
                type: "integer",
                nullable: true);

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
                name: "Nome",
                table: "cliente",
                type: "character varying(300)",
                maxLength: 300,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "character varying(300)",
                oldMaxLength: 300);

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
                name: "CNPJ",
                table: "cliente",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "CEP",
                table: "cliente",
                type: "character varying(20)",
                maxLength: 20,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "character varying(20)",
                oldMaxLength: 20);

            migrationBuilder.AlterColumn<string>(
                name: "estadoUF",
                table: "cidade",
                type: "character varying(3)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "character varying(3)");

            migrationBuilder.AlterColumn<string>(
                name: "Descricao",
                table: "cidade",
                type: "character varying(500)",
                maxLength: 500,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "character varying(500)",
                oldMaxLength: 500);

            migrationBuilder.AlterColumn<string>(
                name: "cidadeCodCidade",
                table: "bairro",
                type: "character varying(150)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "character varying(150)");

            migrationBuilder.AlterColumn<string>(
                name: "Descricao",
                table: "bairro",
                type: "character varying(500)",
                maxLength: 500,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "character varying(500)",
                oldMaxLength: 500);

            migrationBuilder.AlterColumn<string>(
                name: "CodCidade",
                table: "bairro",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.CreateTable(
                name: "endereco",
                columns: table => new
                {
                    CodCliente = table.Column<int>(type: "integer", nullable: false),
                    bairroCodBairro = table.Column<string>(type: "character varying(200)", nullable: true),
                    cidadeCodCidade = table.Column<string>(type: "character varying(150)", nullable: true),
                    estadoUF = table.Column<string>(type: "character varying(3)", nullable: true),
                    Logradouro = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_endereco", x => x.CodCliente);
                    table.ForeignKey(
                        name: "FK_endereco_bairro_bairroCodBairro",
                        column: x => x.bairroCodBairro,
                        principalTable: "bairro",
                        principalColumn: "CodBairro");
                    table.ForeignKey(
                        name: "FK_endereco_cidade_cidadeCodCidade",
                        column: x => x.cidadeCodCidade,
                        principalTable: "cidade",
                        principalColumn: "CodCidade");
                    table.ForeignKey(
                        name: "FK_endereco_cliente_CodCliente",
                        column: x => x.CodCliente,
                        principalTable: "cliente",
                        principalColumn: "CodCliente",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_endereco_estado_estadoUF",
                        column: x => x.estadoUF,
                        principalTable: "estado",
                        principalColumn: "UF");
                });

            migrationBuilder.CreateIndex(
                name: "IX_funcionario_enderecoCodCliente",
                table: "funcionario",
                column: "enderecoCodCliente");

            migrationBuilder.CreateIndex(
                name: "IX_estabelecimento_enderecoCodCliente",
                table: "estabelecimento",
                column: "enderecoCodCliente");

            migrationBuilder.CreateIndex(
                name: "IX_endereco_bairroCodBairro",
                table: "endereco",
                column: "bairroCodBairro");

            migrationBuilder.CreateIndex(
                name: "IX_endereco_cidadeCodCidade",
                table: "endereco",
                column: "cidadeCodCidade");

            migrationBuilder.CreateIndex(
                name: "IX_endereco_estadoUF",
                table: "endereco",
                column: "estadoUF");

            migrationBuilder.AddForeignKey(
                name: "FK_bairro_cidade_cidadeCodCidade",
                table: "bairro",
                column: "cidadeCodCidade",
                principalTable: "cidade",
                principalColumn: "CodCidade");

            migrationBuilder.AddForeignKey(
                name: "FK_cidade_estado_estadoUF",
                table: "cidade",
                column: "estadoUF",
                principalTable: "estado",
                principalColumn: "UF");

            migrationBuilder.AddForeignKey(
                name: "FK_estabelecimento_endereco_enderecoCodCliente",
                table: "estabelecimento",
                column: "enderecoCodCliente",
                principalTable: "endereco",
                principalColumn: "CodCliente");

            migrationBuilder.AddForeignKey(
                name: "FK_funcionario_endereco_enderecoCodCliente",
                table: "funcionario",
                column: "enderecoCodCliente",
                principalTable: "endereco",
                principalColumn: "CodCliente");
        }
    }
}
