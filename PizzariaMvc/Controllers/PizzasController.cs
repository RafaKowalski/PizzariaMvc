using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PizzariaMvc.Data;
using PizzariaMvc.Models;
using PizzariaMvc.Services;

namespace PizzariaMvc.Controllers
{
    public class PizzasController : Controller
    {
        private readonly PizzasService _pizzasService;

        public PizzasController(PizzasService pizzasService)
        {
            _pizzasService = pizzasService;
        }

        // GET: Pizzas
        public async Task<IActionResult> Index()
        {
            return View(await _pizzasService.FindAllPizzasAsync());
        }

        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
                return NotFound();

            var pizzas = await _pizzasService.ProcuraIdPizza(id);

            if (pizzas == null)
                return NotFound();

            return View(pizzas);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("TamanhoPizza,Preco")] Pizza pizza)
        {
            if (id != pizza.Id)
                return NotFound();

            if (ModelState.IsValid)
            {
                try
                {
                    await _pizzasService.EditaPizza(pizza);
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PizzaExiste(pizza.Id))
                        return NotFound();
                    else
                        throw;
                }
                return RedirectToAction(nameof(Index));
            }
            return View(pizza);
        }

        private bool PizzaExiste(int id)
        {
            return _pizzasService.PizzaExiste(id);
        }
    }
}
