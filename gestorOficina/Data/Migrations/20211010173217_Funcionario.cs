using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace Oficina.Dados.Migrations
{
    public partial class Funcionario : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "funcionario",
                columns: table => new
                {
                    CodFuncionario = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Nome = table.Column<string>(type: "character varying(300)", maxLength: 300, nullable: true),
                    CNPJ = table.Column<string>(type: "text", nullable: true),
                    InscricaoMunicipal = table.Column<string>(type: "character varying(150)", maxLength: 150, nullable: true),
                    RazaoSocial = table.Column<string>(type: "character varying(250)", maxLength: 250, nullable: true),
                    Endereco = table.Column<string>(type: "character varying(300)", maxLength: 300, nullable: true),
                    CEP = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: true),
                    UF = table.Column<string>(type: "character varying(3)", maxLength: 3, nullable: true),
                    Telefone = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: true),
                    Email = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    CodBairro = table.Column<string>(type: "text", nullable: true),
                    bairroCodBairro = table.Column<string>(type: "character varying(200)", nullable: true),
                    CodCidade = table.Column<string>(type: "text", nullable: true),
                    cidadeCodCidade = table.Column<string>(type: "character varying(150)", nullable: true),
                    estadoUF = table.Column<string>(type: "character varying(3)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_funcionario", x => x.CodFuncionario);
                    table.ForeignKey(
                        name: "FK_funcionario_bairro_bairroCodBairro",
                        column: x => x.bairroCodBairro,
                        principalTable: "bairro",
                        principalColumn: "CodBairro",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_funcionario_cidade_cidadeCodCidade",
                        column: x => x.cidadeCodCidade,
                        principalTable: "cidade",
                        principalColumn: "CodCidade",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_funcionario_estado_estadoUF",
                        column: x => x.estadoUF,
                        principalTable: "estado",
                        principalColumn: "UF",
                        onDelete: ReferentialAction.Restrict);
                });

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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "funcionario");
        }
    }
}
