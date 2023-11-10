using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace Oficina.Dados.Migrations
{
    public partial class Estrutura_Inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "estado",
                columns: table => new
                {
                    UF = table.Column<string>(type: "character varying(3)", maxLength: 3, nullable: false),
                    Descricao = table.Column<string>(type: "character varying(250)", maxLength: 250, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_estado", x => x.UF);
                });

            migrationBuilder.CreateTable(
                name: "cidade",
                columns: table => new
                {
                    CodCidade = table.Column<string>(type: "character varying(150)", maxLength: 150, nullable: false),
                    Descricao = table.Column<string>(type: "character varying(500)", maxLength: 500, nullable: true),
                    UF = table.Column<string>(type: "text", nullable: true),
                    estadoUF = table.Column<string>(type: "character varying(3)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cidade", x => x.CodCidade);
                    table.ForeignKey(
                        name: "FK_cidade_estado_estadoUF",
                        column: x => x.estadoUF,
                        principalTable: "estado",
                        principalColumn: "UF",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "bairro",
                columns: table => new
                {
                    CodBairro = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: false),
                    Descricao = table.Column<string>(type: "character varying(500)", maxLength: 500, nullable: true),
                    CodCidade = table.Column<string>(type: "text", nullable: true),
                    cidadeCodCidade = table.Column<string>(type: "character varying(150)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_bairro", x => x.CodBairro);
                    table.ForeignKey(
                        name: "FK_bairro_cidade_cidadeCodCidade",
                        column: x => x.cidadeCodCidade,
                        principalTable: "cidade",
                        principalColumn: "CodCidade",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "cliente",
                columns: table => new
                {
                    CodCliente = table.Column<int>(type: "integer", nullable: false)
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
                    table.PrimaryKey("PK_cliente", x => x.CodCliente);
                    table.ForeignKey(
                        name: "FK_cliente_bairro_bairroCodBairro",
                        column: x => x.bairroCodBairro,
                        principalTable: "bairro",
                        principalColumn: "CodBairro",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_cliente_cidade_cidadeCodCidade",
                        column: x => x.cidadeCodCidade,
                        principalTable: "cidade",
                        principalColumn: "CodCidade",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_cliente_estado_estadoUF",
                        column: x => x.estadoUF,
                        principalTable: "estado",
                        principalColumn: "UF",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "estabelecimento",
                columns: table => new
                {
                    CodEstabelecimento = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    NomeEstabelecimento = table.Column<string>(type: "character varying(300)", maxLength: 300, nullable: true),
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
                    table.PrimaryKey("PK_estabelecimento", x => x.CodEstabelecimento);
                    table.ForeignKey(
                        name: "FK_estabelecimento_bairro_bairroCodBairro",
                        column: x => x.bairroCodBairro,
                        principalTable: "bairro",
                        principalColumn: "CodBairro",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_estabelecimento_cidade_cidadeCodCidade",
                        column: x => x.cidadeCodCidade,
                        principalTable: "cidade",
                        principalColumn: "CodCidade",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_estabelecimento_estado_estadoUF",
                        column: x => x.estadoUF,
                        principalTable: "estado",
                        principalColumn: "UF",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_bairro_cidadeCodCidade",
                table: "bairro",
                column: "cidadeCodCidade");

            migrationBuilder.CreateIndex(
                name: "IX_cidade_estadoUF",
                table: "cidade",
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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "cliente");

            migrationBuilder.DropTable(
                name: "estabelecimento");

            migrationBuilder.DropTable(
                name: "bairro");

            migrationBuilder.DropTable(
                name: "cidade");

            migrationBuilder.DropTable(
                name: "estado");
        }
    }
}
