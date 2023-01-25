using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.FileProviders;
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
            return await _pizzariaMvcDbContext.Pizzas.OrderBy(x => x.TamanhoPizza).ToListAsync();
        }

        public async Task AddPizza(Pizza pizza)
        {
            _pizzariaMvcDbContext.Add(pizza);
            await _pizzariaMvcDbContext.SaveChangesAsync();
        }

        public async Task<Pizza> ProcuraIdPizza(int? id)
        {
            return await _pizzariaMvcDbContext.Pizzas.FindAsync(id);
        }

        public async Task EditaPizza(Pizza pizza)
        {
            _pizzariaMvcDbContext.Update(pizza);
            await _pizzariaMvcDbContext.SaveChangesAsync();
        }

        public bool PizzaExiste(int id)
        {
            return _pizzariaMvcDbContext.Pizzas.Any(p => p.Id == id);
        }
    }
}
