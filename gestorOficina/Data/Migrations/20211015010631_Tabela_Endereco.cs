using Microsoft.EntityFrameworkCore.Migrations;

namespace Oficina.Dados.Migrations
{
    public partial class Tabela_Endereco : Migration
    {
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
                name: "Endereco",
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
                name: "Endereco",
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
                name: "Endereco",
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

            migrationBuilder.AddColumn<int>(
                name: "enderecoCodCliente",
                table: "funcionario",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "enderecoCodCliente",
                table: "estabelecimento",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "endereco",
                columns: table => new
                {
                    CodCliente = table.Column<int>(type: "integer", nullable: false),
                    Logradouro = table.Column<string>(type: "text", nullable: true),
                    bairroCodBairro = table.Column<string>(type: "character varying(200)", nullable: true),
                    cidadeCodCidade = table.Column<string>(type: "character varying(150)", nullable: true),
                    estadoUF = table.Column<string>(type: "character varying(3)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_endereco", x => x.CodCliente);
                    table.ForeignKey(
                        name: "FK_endereco_bairro_bairroCodBairro",
                        column: x => x.bairroCodBairro,
                        principalTable: "bairro",
                        principalColumn: "CodBairro",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_endereco_cidade_cidadeCodCidade",
                        column: x => x.cidadeCodCidade,
                        principalTable: "cidade",
                        principalColumn: "CodCidade",
                        onDelete: ReferentialAction.Restrict);
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
                        principalColumn: "UF",
                        onDelete: ReferentialAction.Restrict);
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
                name: "FK_estabelecimento_endereco_enderecoCodCliente",
                table: "estabelecimento",
                column: "enderecoCodCliente",
                principalTable: "endereco",
                principalColumn: "CodCliente",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_funcionario_endereco_enderecoCodCliente",
                table: "funcionario",
                column: "enderecoCodCliente",
                principalTable: "endereco",
                principalColumn: "CodCliente",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.AddColumn<string>(
                name: "Endereco",
                table: "funcionario",
                type: "character varying(300)",
                maxLength: 300,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "bairroCodBairro",
                table: "funcionario",
                type: "character varying(200)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "cidadeCodCidade",
                table: "funcionario",
                type: "character varying(150)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "estadoUF",
                table: "funcionario",
                type: "character varying(3)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Endereco",
                table: "estabelecimento",
                type: "character varying(300)",
                maxLength: 300,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "bairroCodBairro",
                table: "estabelecimento",
                type: "character varying(200)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "cidadeCodCidade",
                table: "estabelecimento",
                type: "character varying(150)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "estadoUF",
                table: "estabelecimento",
                type: "character varying(3)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Endereco",
                table: "cliente",
                type: "character varying(300)",
                maxLength: 300,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "bairroCodBairro",
                table: "cliente",
                type: "character varying(200)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "cidadeCodCidade",
                table: "cliente",
                type: "character varying(150)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "estadoUF",
                table: "cliente",
                type: "character varying(3)",
                nullable: true);

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
                name: "FK_cliente_bairro_bairroCodBairro",
                table: "cliente",
                column: "bairroCodBairro",
                principalTable: "bairro",
                principalColumn: "CodBairro",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_cliente_cidade_cidadeCodCidade",
                table: "cliente",
                column: "cidadeCodCidade",
                principalTable: "cidade",
                principalColumn: "CodCidade",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_cliente_estado_estadoUF",
                table: "cliente",
                column: "estadoUF",
                principalTable: "estado",
                principalColumn: "UF",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_estabelecimento_bairro_bairroCodBairro",
                table: "estabelecimento",
                column: "bairroCodBairro",
                principalTable: "bairro",
                principalColumn: "CodBairro",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_estabelecimento_cidade_cidadeCodCidade",
                table: "estabelecimento",
                column: "cidadeCodCidade",
                principalTable: "cidade",
                principalColumn: "CodCidade",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_estabelecimento_estado_estadoUF",
                table: "estabelecimento",
                column: "estadoUF",
                principalTable: "estado",
                principalColumn: "UF",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_funcionario_bairro_bairroCodBairro",
                table: "funcionario",
                column: "bairroCodBairro",
                principalTable: "bairro",
                principalColumn: "CodBairro",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_funcionario_cidade_cidadeCodCidade",
                table: "funcionario",
                column: "cidadeCodCidade",
                principalTable: "cidade",
                principalColumn: "CodCidade",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_funcionario_estado_estadoUF",
                table: "funcionario",
                column: "estadoUF",
                principalTable: "estado",
                principalColumn: "UF",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
