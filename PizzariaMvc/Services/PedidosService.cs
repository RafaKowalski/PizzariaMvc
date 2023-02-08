using Microsoft.EntityFrameworkCore;
using PizzariaMvc.Data;
using PizzariaMvc.Data.Enum;
using PizzariaMvc.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzariaMvc.Services
{
    public class PedidosService
    {
        private readonly PizzariaMvcContext _pizzariaMvcContext;

        public PedidosService(PizzariaMvcContext pizzariaMvcContext)
        {
            _pizzariaMvcContext = pizzariaMvcContext;
        }

        public async Task<ICollection<Pedido>> FindAllPedidosAsync()
        {
            return await _pizzariaMvcContext.Pedidos.Include(c => c.Clientes).Include(p => p.Pizzas).ToListAsync();
        }

        public async Task<Pedido> ValidaTamanhoComQuantidade()
        {
            var pedido = new Pedido();
            var tamanhoPizza = new TamanhoPizza();

            if (pedido.TamanhoPizza == TamanhoPizza.Pequena)
                pedido.QtdPizzas = 2;

            if (pedido.TamanhoPizza == TamanhoPizza.Media)
                pedido.QtdPizzas = 3;

            if (pedido.TamanhoPizza == TamanhoPizza.Grande)
                pedido.QtdPizzas = 4;

            if (pedido.TamanhoPizza == TamanhoPizza.Familia)
                pedido.QtdPizzas = 4;

            return pedido;
        }
    }
}
