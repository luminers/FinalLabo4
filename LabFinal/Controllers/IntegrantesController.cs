using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using LabFinal.Data;
using LabFinal.Models;

namespace LabFinal.Controllers
{
    public class IntegrantesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public IntegrantesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Integrantes
        public async Task<IActionResult> Index()
        {
            return View(await _context.integrantes.ToListAsync());
        }

        // GET: Integrantes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var integrante = await _context.integrantes
                .FirstOrDefaultAsync(m => m.Id == id);
            if (integrante == null)
            {
                return NotFound();
            }

            return View(integrante);
        }

        // GET: Integrantes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Integrantes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,nombre,apellido,biografia,foto,IdAlbum")] Integrante integrante)
        {
            if (ModelState.IsValid)
            {
                _context.Add(integrante);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["idAlbum"] = new SelectList(_context.categorias, "Id", "nombre", integrante.album);
            return View(integrante);
        }

        // GET: Integrantes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var integrante = await _context.integrantes.FindAsync(id);
            if (integrante == null)
            {
                return NotFound();
            }
            return View(integrante);
        }

        // POST: Integrantes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,nombre,apellido,biografia,foto,IdAlbum")] Integrante integrante)
        {
            if (id != integrante.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(integrante);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!IntegranteExists(integrante.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(integrante);
        }

        // GET: Integrantes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var integrante = await _context.integrantes
                .FirstOrDefaultAsync(m => m.Id == id);
            if (integrante == null)
            {
                return NotFound();
            }

            return View(integrante);
        }

        // POST: Integrantes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var integrante = await _context.integrantes.FindAsync(id);
            _context.integrantes.Remove(integrante);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool IntegranteExists(int id)
        {
            return _context.integrantes.Any(e => e.Id == id);
        }
    }
}
