using eTickets.Data;
using Microsoft.AspNetCore.Mvc;

namespace eTickets.Controllers
{
    public class ActorMovieController : Controller
    {
        private readonly AppDbContext _context;

        public ActorMovieController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {            
            return View();
        }
    }
}
