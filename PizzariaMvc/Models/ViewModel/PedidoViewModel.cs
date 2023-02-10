using System;
using System.Collections.Generic;

namespace PizzariaMvc.Models.ViewModel
{
    public class PedidoViewModel
    {
        public Pedido Pedido { get; set; }
        public ICollection<Cliente> Cliente { get; set; }
        public ICollection<Pizza> Pizza { get; set; }
        public DateTime Data { get; set; }

        public PedidoViewModel(Pedido pedido, ICollection<Cliente> clientes, ICollection<Pizza> pizzas)
        {
            Pedido = pedido;
            Cliente = clientes;
            Pizza = pizzas;
        }

        public PedidoViewModel(ICollection<Cliente> cliente, ICollection<Pizza> pizza)
        {
            Cliente = cliente;
            Pizza = pizza;
        }

        public PedidoViewModel(Pedido pedido, ICollection<Cliente> cliente, ICollection<Pizza> pizza, DateTime data) : this(pedido, cliente, pizza)
        {
            Data = data;
        }
    }
}
