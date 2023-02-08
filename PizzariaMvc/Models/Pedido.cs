using PizzariaMvc.Data.Enum;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PizzariaMvc.Models
{
    public class Pedido
    {
        [Display(Name = "Número do Registro")]
        public int Id { get; set; }
        [Display(Name = "Quantidade de Sabores")]
        public int QtdPizzas { get; set; }
        public TamanhoPizza TamanhoPizza { get; set; }
        public double TrocoPara { get; set; }
        public double Troco { get; set; }
        public Cliente Clientes { get; set; }
        public Pizza Pizzas { get; set; }
        public int ClienteId { get; set; }
        public int PizzaId { get; set; }
    }
}
