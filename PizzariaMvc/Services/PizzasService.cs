using Microsoft.EntityFrameworkCore;
using PizzariaMvc.Data;
using PizzariaMvc.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzariaMvc.Services
{
    public class PizzasService
    {
        private readonly PizzariaMvcContext _pizzariaMvcDbContext;

        public PizzasService(PizzariaMvcContext pizzariaMvcContext)
        {
            _pizzariaMvcDbContext = pizzariaMvcContext;
        }

        public async Task<List<Pizza>> FindAllPizzasAsync()
        {
            return await _pizzariaMvcDbContext.Pizzas.OrderBy(x => x.Sabor).ToListAsync();
        }

        public async Task AddPizza(Pizza pizza)
        {
            _pizzariaMvcDbContext.Add(pizza);
            await _pizzariaMvcDbContext.SaveChangesAsync();
        }
    }
}
