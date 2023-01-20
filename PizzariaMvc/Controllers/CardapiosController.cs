using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PizzariaMvc.Data;
using System.Threading.Tasks;

namespace PizzariaMvc.Controllers
{
    public class CardapiosController : Controller
    {

        private readonly PizzariaMvcContext _context;

        public CardapiosController(PizzariaMvcContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _context.Cardapios.ToListAsync());
        }
    }
}
