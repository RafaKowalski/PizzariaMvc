using Microsoft.EntityFrameworkCore.Migrations;

namespace PizzariaMvc.Migrations
{
    public partial class PopulaCardapioPizza : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("Insert into Pizzas(Sabor,Preco,Descricao)" + "Values('Calabresa',25.50, 'Pizza de calabresa molho de tomate e muzzarela')");
            migrationBuilder.Sql("Insert into Pizzas(Sabor,Preco,Descricao)" + "Values('Frango Catupiry',27.50, 'Pizza de frango com catupiry molho de tomate e muzzarela')");
            migrationBuilder.Sql("Insert into Pizzas(Sabor,Preco,Descricao)" + "Values('Coração',30.00, 'Pizza de coração com cebola molho de tomate e muzzarela')");
            migrationBuilder.Sql("Insert into Pizzas(Sabor,Preco,Descricao)" + "Values('4 queijos',24.70, 'Pizza de 4 quiejos com muzzarela, gongorzola parmesão provolone e molho de tomate')");
            migrationBuilder.Sql("Insert into Pizzas(Sabor,Preco,Descricao)" + "Values('Filé com palhas',30.50, 'Pizza de filé mignon com batata palha molho de tomate e muzzarela')");
            migrationBuilder.Sql("Insert into Pizzas(Sabor,Preco,Descricao)" + "Values('Camarão',33.50, 'Pizza de Camarão com molho de tomate e muzzarela')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("Delete from Produtos");
        }
    }
}
