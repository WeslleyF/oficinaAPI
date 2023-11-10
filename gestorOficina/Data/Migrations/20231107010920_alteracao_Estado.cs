using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Oficina.Dados.Migrations
{
    public partial class alteracao_Estado : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UF",
                table: "cidade");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UF",
                table: "cidade",
                type: "text",
                nullable: true);
        }
    }
}
