using Microsoft.EntityFrameworkCore.Migrations;

namespace PizzariaMvc.Migrations
{
    public partial class RefatorandoAtributosClassePedido : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ValorFinalDoPedido",
                table: "Pedidos",
                newName: "Troco");

            migrationBuilder.AddColumn<int>(
                name: "PedidoId",
                table: "Pizzas",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ClienteId",
                table: "Pedidos",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PizzaId",
                table: "Pedidos",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PedidoId",
                table: "Clientes",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Pizzas_PedidoId",
                table: "Pizzas",
                column: "PedidoId");

            migrationBuilder.CreateIndex(
                name: "IX_Clientes_PedidoId",
                table: "Clientes",
                column: "PedidoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Clientes_Pedidos_PedidoId",
                table: "Clientes",
                column: "PedidoId",
                principalTable: "Pedidos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Pizzas_Pedidos_PedidoId",
                table: "Pizzas",
                column: "PedidoId",
                principalTable: "Pedidos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Clientes_Pedidos_PedidoId",
                table: "Clientes");

            migrationBuilder.DropForeignKey(
                name: "FK_Pizzas_Pedidos_PedidoId",
                table: "Pizzas");

            migrationBuilder.DropIndex(
                name: "IX_Pizzas_PedidoId",
                table: "Pizzas");

            migrationBuilder.DropIndex(
                name: "IX_Clientes_PedidoId",
                table: "Clientes");

            migrationBuilder.DropColumn(
                name: "PedidoId",
                table: "Pizzas");

            migrationBuilder.DropColumn(
                name: "ClienteId",
                table: "Pedidos");

            migrationBuilder.DropColumn(
                name: "PizzaId",
                table: "Pedidos");

            migrationBuilder.DropColumn(
                name: "PedidoId",
                table: "Clientes");

            migrationBuilder.RenameColumn(
                name: "Troco",
                table: "Pedidos",
                newName: "ValorFinalDoPedido");
        }
    }
}
