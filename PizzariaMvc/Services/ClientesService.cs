using Microsoft.EntityFrameworkCore;
using PizzariaMvc.Data;
using PizzariaMvc.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzariaMvc.Services
{
    public class ClientesService
    {
        private readonly PizzariaMvcContext _pizzariaMvcDbContext;

        public ClientesService(PizzariaMvcContext pizzariaMvcContext)
        {
            _pizzariaMvcDbContext = pizzariaMvcContext;
        }

        public async Task<List<Cliente>> FindAllClienteAsync()
        {
            return await _pizzariaMvcDbContext.Clientes.OrderBy(x => x.Nome).ToListAsync();
        }
    }
}
