using Microsoft.EntityFrameworkCore;
using PizzariaMvc.Models;

namespace PizzariaMvc.Data
{
    public class PizzariaMvcContext : DbContext
    {
        public PizzariaMvcContext (DbContextOptions<PizzariaMvcContext> options) : base(options)
        {
        }

        public DbSet<Pizza> Pizzas { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public  DbSet<Pedido> Pedidos{ get; set; }
        public DbSet<Cardapio> Cardapios { get; set; }
    }
}
