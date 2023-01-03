namespace PizzariaMvc.Models
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string Endereco { get; set; }
        public int NumeroEndereco { get; set; }
        public string Complemento { get; set; }

        public Cliente()
        {
        }

        public Cliente(int id, string nome, string telefone, string endereco, int numeroEndereco, string complemento)
        {
            Id = id;
            Nome = nome;
            Telefone = telefone;
            Endereco = endereco;
            NumeroEndereco = numeroEndereco;
            Complemento = complemento;
        }
    }
}
