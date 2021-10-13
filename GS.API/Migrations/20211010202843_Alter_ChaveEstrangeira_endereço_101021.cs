using Microsoft.EntityFrameworkCore.Migrations;

namespace GS.API.Migrations
{
    public partial class Alter_ChaveEstrangeira_endereço_101021 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Clientes_Enderecos_CliCodEndereco",
                schema: "doce",
                table: "Clientes");

            migrationBuilder.DropForeignKey(
                name: "FK_Fornecedores_Enderecos_ForCodEndereco",
                schema: "doce",
                table: "Fornecedores");

            migrationBuilder.DropForeignKey(
                name: "FK_Vendedores_Enderecos_VenCodEndereco",
                schema: "doce",
                table: "Vendedores");

            migrationBuilder.DropIndex(
                name: "IX_Vendedores_VenCodEndereco",
                schema: "doce",
                table: "Vendedores");

            migrationBuilder.DropIndex(
                name: "IX_Fornecedores_ForCodEndereco",
                schema: "doce",
                table: "Fornecedores");

            migrationBuilder.DropIndex(
                name: "IX_Clientes_CliCodEndereco",
                schema: "doce",
                table: "Clientes");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Vendedores_VenCodEndereco",
                schema: "doce",
                table: "Vendedores",
                column: "VenCodEndereco");

            migrationBuilder.CreateIndex(
                name: "IX_Fornecedores_ForCodEndereco",
                schema: "doce",
                table: "Fornecedores",
                column: "ForCodEndereco");

            migrationBuilder.CreateIndex(
                name: "IX_Clientes_CliCodEndereco",
                schema: "doce",
                table: "Clientes",
                column: "CliCodEndereco");

            migrationBuilder.AddForeignKey(
                name: "FK_Clientes_Enderecos_CliCodEndereco",
                schema: "doce",
                table: "Clientes",
                column: "CliCodEndereco",
                principalSchema: "doce",
                principalTable: "Enderecos",
                principalColumn: "EnderecoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Fornecedores_Enderecos_ForCodEndereco",
                schema: "doce",
                table: "Fornecedores",
                column: "ForCodEndereco",
                principalSchema: "doce",
                principalTable: "Enderecos",
                principalColumn: "EnderecoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Vendedores_Enderecos_VenCodEndereco",
                schema: "doce",
                table: "Vendedores",
                column: "VenCodEndereco",
                principalSchema: "doce",
                principalTable: "Enderecos",
                principalColumn: "EnderecoId");
        }
    }
}
