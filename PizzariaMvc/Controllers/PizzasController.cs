using System;
using System.Collections.Generic;
using System.Linq;
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
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Sabor,TamanhoPizza,Preco,Descricao")] Pizza pizza)
        {
            if (ModelState.IsValid)
            {
                _pizzasService.AddPizza(pizza);
            }
            return View(pizza);
        }
    }
}
