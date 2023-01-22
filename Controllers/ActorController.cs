using eTickets.Data;
using eTickets.Data.Services;
using eTickets.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace eTickets.Controllers
{
    public class ActorController : Controller
    {
        //private readonly AppDbContext _context;

        //public ActorController(AppDbContext context)
        //{
        //    _context = context;
        //}
        private readonly IActorService _service;

        public ActorController(IActorService service)
        {
            _service = service;
        }

        public async Task<IActionResult> Index()
        {
            var allActor = await _service.GetAll();
            return View(allActor);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create([Bind("FullName,ProfilePictureURL,Bio")]Actor actor)
        {
            if (!ModelState.IsValid)
            {
                return View(actor);
            }
            _service.Add(actor);
            return RedirectToAction(nameof(Index));
        }
    }
}
