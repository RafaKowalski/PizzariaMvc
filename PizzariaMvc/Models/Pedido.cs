using PizzariaMvc.Data.Enum;
using System.Collections.Generic;

namespace PizzariaMvc.Models
{
    public class Pedido
    {
        public int Id { get; set; }
        public int QtdPizzas { get; set; }
        public TamanhoPizza TamanhoPizza { get; set; }
        public double TrocoPara { get; set; }
        public double Troco { get; set; }
        public ICollection<Cliente> Clientes { get; set; }
        public ICollection<Pizza> Pizzas { get; set; }
        public int ClienteId { get; set; }
        public int PizzaId { get; set; }
    }
}
