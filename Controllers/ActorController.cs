﻿using eTickets.Data;
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
            var allActor = await _service.GetAllAsync();
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
            await _service.AddAsync(actor);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public async Task<IActionResult> Details(int id)
        {
            var result = await _service.GetByIdAsync(id);

            if(result == null) return View("Empty");
            return View(result);
        }
        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            var result = await _service.GetByIdAsync(id);

            if (result == null) return View("NotFound");
            return View(result);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(int id,[Bind("Id,FullName,ProfilePictureURL,Bio")] Actor actor)
        {
            if (!ModelState.IsValid)
            {
                return View(actor);
            }
            await _service.UpdateAsync(id,actor);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            var result = await _service.GetByIdAsync(id);

            if (result == null) return View("NotFound");
            return View(result);
        }
        [HttpPost,ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var result = await _service.GetByIdAsync(id);

            if (result == null) return View("NotFound");

            await _service.DeleteAsync(id);
            return RedirectToAction("Index");
        }
    }
}
