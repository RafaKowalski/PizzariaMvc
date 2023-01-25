using System.Collections.Generic;

namespace PizzariaMvc.Models
{
    public class Cardapio
    {
        public int Id { get; set; }
        public string Sabor { get; set; }
        public string Descricao { get; set; }

        public Cardapio()
        {
        }
        public Cardapio(int id, string sabor, string descricao)
        {
            Id = id;
            Sabor = sabor;
            Descricao = descricao;
        }
    }
}
