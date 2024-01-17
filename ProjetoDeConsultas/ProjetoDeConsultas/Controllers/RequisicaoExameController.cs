using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ProjetoDeConsultas.Data;
using ProjetoDeConsultas.Models;

namespace ProjetoDeConsultas.Controllers
{
    public class RequisicaoExameController : Controller
    {
        private readonly ProjetoDeConsultasContext _context;

        public RequisicaoExameController(ProjetoDeConsultasContext context)
        {
            _context = context;
        }

        // GET: RequisicaoExame
        public async Task<IActionResult> Index()
        {
              return _context.RequisicaoExame != null ? 
                          View(await _context.RequisicaoExame.ToListAsync()) :
                          Problem("Entity set 'ProjetoDeConsultasContext.RequisicaoExame'  is null.");
        }

        // GET: RequisicaoExame/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.RequisicaoExame == null)
            {
                return NotFound();
            }

            var requisicaoExame = await _context.RequisicaoExame
                .FirstOrDefaultAsync(m => m.RequisicaoExameId == id);
            if (requisicaoExame == null)
            {
                return NotFound();
            }

            return View(requisicaoExame);
        }

        // GET: RequisicaoExame/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: RequisicaoExame/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("RequisicaoExameId,Cliente,Medico,Exame")] RequisicaoExame requisicaoExame)
        {
            if (ModelState.IsValid)
            {
                _context.Add(requisicaoExame);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(requisicaoExame);
        }

        // GET: RequisicaoExame/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.RequisicaoExame == null)
            {
                return NotFound();
            }

            var requisicaoExame = await _context.RequisicaoExame.FindAsync(id);
            if (requisicaoExame == null)
            {
                return NotFound();
            }
            return View(requisicaoExame);
        }

        // POST: RequisicaoExame/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("RequisicaoExameId,Cliente,Medico,Exame")] RequisicaoExame requisicaoExame)
        {
            if (id != requisicaoExame.RequisicaoExameId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(requisicaoExame);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RequisicaoExameExists(requisicaoExame.RequisicaoExameId))
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
            return View(requisicaoExame);
        }

        // GET: RequisicaoExame/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.RequisicaoExame == null)
            {
                return NotFound();
            }

            var requisicaoExame = await _context.RequisicaoExame
                .FirstOrDefaultAsync(m => m.RequisicaoExameId == id);
            if (requisicaoExame == null)
            {
                return NotFound();
            }

            return View(requisicaoExame);
        }

        // POST: RequisicaoExame/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.RequisicaoExame == null)
            {
                return Problem("Entity set 'ProjetoDeConsultasContext.RequisicaoExame'  is null.");
            }
            var requisicaoExame = await _context.RequisicaoExame.FindAsync(id);
            if (requisicaoExame != null)
            {
                _context.RequisicaoExame.Remove(requisicaoExame);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RequisicaoExameExists(int id)
        {
          return (_context.RequisicaoExame?.Any(e => e.RequisicaoExameId == id)).GetValueOrDefault();
        }
    }
}
