using Microsoft.EntityFrameworkCore.Migrations;

namespace GS.API.Migrations
{
    public partial class Alter_Endereco_101021 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "EnderecoOrigem",
                schema: "doce",
                table: "Enderecos",
                type: "integer",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EnderecoOrigem",
                schema: "doce",
                table: "Enderecos");
        }
    }
}
