using Microsoft.EntityFrameworkCore;
using PizzariaMvc.Data;
using PizzariaMvc.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzariaMvc.Services
{
    public class CardapiosService
    {
        private readonly PizzariaMvcContext _pizzariaMvcDbContext;

        public CardapiosService(PizzariaMvcContext pizzariaMvcContext)
        {
            _pizzariaMvcDbContext = pizzariaMvcContext;
        }

        public async Task<List<Cardapio>> ShowCardapioAsync()
        {
            return await _pizzariaMvcDbContext.Cardapios.OrderBy(x => x.Sabor).ToListAsync();
        }
    }
}
