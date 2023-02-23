using Microsoft.EntityFrameworkCore.Migrations;

namespace PizzariaMvc.Migrations
{
    public partial class RetornaDados : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                name: "PedidoId",
                table: "Clientes");

            migrationBuilder.CreateIndex(
                name: "IX_Pedidos_ClienteId",
                table: "Pedidos",
                column: "ClienteId");

            migrationBuilder.CreateIndex(
                name: "IX_Pedidos_PizzaId",
                table: "Pedidos",
                column: "PizzaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Pedidos_Clientes_ClienteId",
                table: "Pedidos",
                column: "ClienteId",
                principalTable: "Clientes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Pedidos_Pizzas_PizzaId",
                table: "Pedidos",
                column: "PizzaId",
                principalTable: "Pizzas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pedidos_Clientes_ClienteId",
                table: "Pedidos");

            migrationBuilder.DropForeignKey(
                name: "FK_Pedidos_Pizzas_PizzaId",
                table: "Pedidos");

            migrationBuilder.DropIndex(
                name: "IX_Pedidos_ClienteId",
                table: "Pedidos");

            migrationBuilder.DropIndex(
                name: "IX_Pedidos_PizzaId",
                table: "Pedidos");

            migrationBuilder.AddColumn<int>(
                name: "PedidoId",
                table: "Pizzas",
                nullable: true);

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
    }
}
