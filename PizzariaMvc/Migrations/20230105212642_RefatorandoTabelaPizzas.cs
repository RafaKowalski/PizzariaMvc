using Microsoft.EntityFrameworkCore.Migrations;

namespace PizzariaMvc.Migrations
{
    public partial class RefatorandoTabelaPizzas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TamanhoPizza",
                table: "Pizzas",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("Delete from Produtos");
        }
    }
}
