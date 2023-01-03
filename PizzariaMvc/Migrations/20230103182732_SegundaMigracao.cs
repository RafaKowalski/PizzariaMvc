using Microsoft.EntityFrameworkCore.Migrations;

namespace PizzariaMvc.Migrations
{
    public partial class SegundaMigracao : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TamanhoPizza",
                table: "Pizzas");

            migrationBuilder.AddColumn<string>(
                name: "Descricao",
                table: "Pizzas",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "Preco",
                table: "Pizzas",
                nullable: false,
                defaultValue: 0.0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Descricao",
                table: "Pizzas");

            migrationBuilder.DropColumn(
                name: "Preco",
                table: "Pizzas");

            migrationBuilder.AddColumn<int>(
                name: "TamanhoPizza",
                table: "Pizzas",
                nullable: false,
                defaultValue: 0);
        }
    }
}
