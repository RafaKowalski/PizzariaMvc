using PizzariaMvc.Data.Enum;

namespace PizzariaMvc.Models
{
    public class Pedido
    {
        public int Id { get; set; }
        public int QtdPizzas { get; set; }
        public TamanhoPizza TamanhoPizza { get; set; }
        public double TrocoPara { get; set; }
        public double ValorFinalDoPedido { get; set; }
    }
}
