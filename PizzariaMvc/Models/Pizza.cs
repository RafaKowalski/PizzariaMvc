using PizzariaMvc.Data.Enum;

namespace PizzariaMvc.Models
{
    public class Pizza
    {
        public int Id { get; set; }
        public TamanhoPizza TamanhoPizza { get; set; }
        public double Preco { get; set; }

        public Pizza()
        {
        }

        public Pizza(int id, TamanhoPizza tamanhoPizza, double preco)
        {
            Id = id;
            TamanhoPizza = tamanhoPizza;
            Preco = preco;
        }
    }
}
