﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Rewrite.Internal.UrlActions;
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

        public async Task<Pizza> Delete(int? id)
        {
            return await _pizzariaMvcDbContext.Pizzas.FirstOrDefaultAsync(p => p.Id == id);
        }

        public async Task ConfirmarDelete(int? id)
        {
            var pizza = await _pizzariaMvcDbContext.Pizzas.FindAsync(id);
             _pizzariaMvcDbContext.Pizzas.Remove(pizza);
            await _pizzariaMvcDbContext.SaveChangesAsync();
        }
    }
}
