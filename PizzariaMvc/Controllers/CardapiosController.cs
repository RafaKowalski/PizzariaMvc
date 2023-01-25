using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PizzariaMvc.Data;
using PizzariaMvc.Services;
using System.Threading.Tasks;

namespace PizzariaMvc.Controllers
{
    public class CardapiosController : Controller
    {

        private readonly CardapiosService _cardapiosService;

        public CardapiosController(CardapiosService cardapiosService)
        {
            _cardapiosService = cardapiosService;
        }

        public async Task<IActionResult> Index()
        {
            var resultado = await _cardapiosService.ShowCardapioAsync();

            return View(resultado);
        }
    }
}
