using Microsoft.EntityFrameworkCore.Migrations;

namespace PizzariaMvc.Migrations
{
    public partial class PopulandoCardapio : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("Insert into Cardapios(Sabor,Descricao)" + "Values('Calabresa','Pizza de Calabresa com queijo muzzarela e molho de tomate')");

            migrationBuilder.Sql("Insert into Cardapios(Sabor,Descricao)" + "Values('Coração','Pizza de Coração com queijo muzzarela e molho de tomate')");

            migrationBuilder.Sql("Insert into Cardapios(Sabor,Descricao)" + "Values('Muzzarela','Pizza de queijo muzzarela e molho de tomate')");

            migrationBuilder.Sql("Insert into Cardapios(Sabor,Descricao)" + "Values('Frango catupiry','Pizza de Frango desfiado com catupiry, queijo muzzarela e molho de tomate')");

            migrationBuilder.Sql("Insert into Cardapios(Sabor,Descricao)" + "Values('Filé com palhas','Pizza de filé mignom com batata palha, queijo muzzarela e molho de tomate')");

            migrationBuilder.Sql("Insert into Cardapios(Sabor,Descricao)" + "Values('Rúcula com tomate seco','Pizza de Rúcula com tomate seco, queijo muzzarela e molho de tomate')");

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("Delete from Cardapios");
        }
    }
}
