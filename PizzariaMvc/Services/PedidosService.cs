using Microsoft.EntityFrameworkCore;
using PizzariaMvc.Data;
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
    }
}
