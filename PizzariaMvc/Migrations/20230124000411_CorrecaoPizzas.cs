using Microsoft.EntityFrameworkCore.Migrations;

namespace PizzariaMvc.Migrations
{
    public partial class CorrecaoPizzas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "Preco",
                table: "Pizzas",
                nullable: false,
                oldClrType: typeof(double));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "Preco",
                table: "Pizzas",
                nullable: false,
                oldClrType: typeof(decimal));
        }
    }
}
