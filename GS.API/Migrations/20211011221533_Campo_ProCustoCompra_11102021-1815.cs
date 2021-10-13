using Microsoft.EntityFrameworkCore.Migrations;

namespace GS.API.Migrations
{
    public partial class Campo_ProCustoCompra_111020211815 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "ProCustoCompra",
                schema: "doce",
                table: "Produtos",
                type: "numeric(15,6)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ProCustoCompra",
                schema: "doce",
                table: "Produtos");
        }
    }
}
