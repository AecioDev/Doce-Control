using Microsoft.EntityFrameworkCore.Migrations;

namespace GS.API.Migrations
{
    public partial class Campos_Fornecedor_1210211649 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FornecedorCPF",
                schema: "doce",
                table: "Fornecedores",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FornecedorContato",
                schema: "doce",
                table: "Fornecedores",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FornecedorEmail",
                schema: "doce",
                table: "Fornecedores",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FornecedorTel1",
                schema: "doce",
                table: "Fornecedores",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FornecedorTel2",
                schema: "doce",
                table: "Fornecedores",
                type: "text",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FornecedorCPF",
                schema: "doce",
                table: "Fornecedores");

            migrationBuilder.DropColumn(
                name: "FornecedorContato",
                schema: "doce",
                table: "Fornecedores");

            migrationBuilder.DropColumn(
                name: "FornecedorEmail",
                schema: "doce",
                table: "Fornecedores");

            migrationBuilder.DropColumn(
                name: "FornecedorTel1",
                schema: "doce",
                table: "Fornecedores");

            migrationBuilder.DropColumn(
                name: "FornecedorTel2",
                schema: "doce",
                table: "Fornecedores");
        }
    }
}
