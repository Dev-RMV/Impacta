using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Aula13_ControleAutomoveis.Data;
using Aula13_ControleAutomoveis.Models;

namespace Aula13_ControleAutomoveis.Controllers
{
    public class VagaController : Controller
    {
        private readonly Aula13_ControleAutomoveisContext _context;

        public VagaController(Aula13_ControleAutomoveisContext context)
        {
            _context = context;
        }

        // GET: Vaga
        public async Task<IActionResult> Index()
        {
              return _context.Vaga != null ? 
                          View(await _context.Vaga.ToListAsync()) :
                          Problem("Entity set 'Aula13_ControleAutomoveisContext.Vaga'  is null.");
        }

        // GET: Vaga/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Vaga == null)
            {
                return NotFound();
            }

            var vaga = await _context.Vaga
                .FirstOrDefaultAsync(m => m.VagaId == id);
            if (vaga == null)
            {
                return NotFound();
            }

            return View(vaga);
        }

        // GET: Vaga/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Vaga/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("VagaId,Numero,ValorPorHora")] Vaga vaga)
        {
            if (ModelState.IsValid)
            {
                _context.Add(vaga);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(vaga);
        }

        // GET: Vaga/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Vaga == null)
            {
                return NotFound();
            }

            var vaga = await _context.Vaga.FindAsync(id);
            if (vaga == null)
            {
                return NotFound();
            }
            return View(vaga);
        }

        // POST: Vaga/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("VagaId,Numero,ValorPorHora")] Vaga vaga)
        {
            if (id != vaga.VagaId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(vaga);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!VagaExists(vaga.VagaId))
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
            return View(vaga);
        }

        // GET: Vaga/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Vaga == null)
            {
                return NotFound();
            }

            var vaga = await _context.Vaga
                .FirstOrDefaultAsync(m => m.VagaId == id);
            if (vaga == null)
            {
                return NotFound();
            }

            return View(vaga);
        }

        // POST: Vaga/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Vaga == null)
            {
                return Problem("Entity set 'Aula13_ControleAutomoveisContext.Vaga'  is null.");
            }
            var vaga = await _context.Vaga.FindAsync(id);
            if (vaga != null)
            {
                _context.Vaga.Remove(vaga);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool VagaExists(int id)
        {
          return (_context.Vaga?.Any(e => e.VagaId == id)).GetValueOrDefault();
        }
    }
}
