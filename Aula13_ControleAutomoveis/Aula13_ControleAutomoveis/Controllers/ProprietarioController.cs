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
    public class ProprietarioController : Controller
    {
        private readonly Aula13_ControleAutomoveisContext _context;

        public ProprietarioController(Aula13_ControleAutomoveisContext context)
        {
            _context = context;
        }

        // GET: Proprietario
        public async Task<IActionResult> Index()
        {
              return _context.Proprietario != null ? 
                          View(await _context.Proprietario.ToListAsync()) :
                          Problem("Entity set 'Aula13_ControleAutomoveisContext.Proprietario'  is null.");
        }

        // GET: Proprietario/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Proprietario == null)
            {
                return NotFound();
            }

            var proprietario = await _context.Proprietario
                .FirstOrDefaultAsync(m => m.ProprietarioId == id);
            if (proprietario == null)
            {
                return NotFound();
            }

            return View(proprietario);
        }

        // GET: Proprietario/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Proprietario/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ProprietarioId,Nome,Cpf,Veiculos")] Proprietario proprietario)
        {
            if (ModelState.IsValid)
            {
                _context.Add(proprietario);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(proprietario);
        }

        // GET: Proprietario/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Proprietario == null)
            {
                return NotFound();
            }

            var proprietario = await _context.Proprietario.FindAsync(id);
            if (proprietario == null)
            {
                return NotFound();
            }
            return View(proprietario);
        }

        // POST: Proprietario/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ProprietarioId,Nome,Cpf,Veiculos")] Proprietario proprietario)
        {
            if (id != proprietario.ProprietarioId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(proprietario);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProprietarioExists(proprietario.ProprietarioId))
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
            return View(proprietario);
        }

        // GET: Proprietario/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Proprietario == null)
            {
                return NotFound();
            }

            var proprietario = await _context.Proprietario
                .FirstOrDefaultAsync(m => m.ProprietarioId == id);
            if (proprietario == null)
            {
                return NotFound();
            }

            return View(proprietario);
        }

        // POST: Proprietario/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Proprietario == null)
            {
                return Problem("Entity set 'Aula13_ControleAutomoveisContext.Proprietario'  is null.");
            }
            var proprietario = await _context.Proprietario.FindAsync(id);
            if (proprietario != null)
            {
                _context.Proprietario.Remove(proprietario);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProprietarioExists(int id)
        {
          return (_context.Proprietario?.Any(e => e.ProprietarioId == id)).GetValueOrDefault();
        }
    }
}
