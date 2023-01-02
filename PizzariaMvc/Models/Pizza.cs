using PizzariaMvc.Data.Enum;

namespace PizzariaMvc.Models
{
    public class Pizza
    {
        public int Id { get; set; }
        public string Sabor { get; set; }
        public TamanhoPizza TamanhoPizza { get; set; }

        public Pizza()
        {
        }

        public Pizza(int id, string sabor, TamanhoPizza tamanhoPizza)
        {
            Id = id;
            Sabor = sabor;
            TamanhoPizza = tamanhoPizza;
        }
    }
}
