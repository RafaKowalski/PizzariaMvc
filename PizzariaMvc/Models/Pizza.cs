using PizzariaMvc.Data.Enum;
using System.ComponentModel.DataAnnotations;

namespace PizzariaMvc.Models
{
    public class Pizza
    {
        public int Id { get; set; }
        public TamanhoPizza TamanhoPizza { get; set; }
        [DisplayFormat(DataFormatString = "{0:F2}")]
        public decimal Preco { get; set; }

        public Pizza()
        {
        }

        public Pizza(int id, TamanhoPizza tamanhoPizza, decimal preco)
        {
            Id = id;
            TamanhoPizza = tamanhoPizza;
            Preco = preco;
        }
    }
}
