using Microsoft.EntityFrameworkCore.Migrations;

namespace PizzariaMvc.Migrations
{
    public partial class PopulandoPizzas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("Insert into Pizzas(TamanhoPizza,Preco)" + "Values(0,15.00)");

            migrationBuilder.Sql("Insert into Pizzas(TamanhoPizza,Preco)" + "Values(1,25.00)");

            migrationBuilder.Sql("Insert into Pizzas(TamanhoPizza,Preco)" + "Values(2,35.00)");

            migrationBuilder.Sql("Insert into Pizzas(TamanhoPizza,Preco)" + "Values(3,45.00)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("Delete from Cardapios");
        }
    }
}
