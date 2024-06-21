using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using iCompass.Models;

namespace iCompass.Controllers
{
    public class TipoSexoController : Controller
    {
        private readonly Contexto _context;

        public TipoSexoController(Contexto context)
        {
            _context = context;
        }

        // GET: TipoSexo
        public async Task<IActionResult> Index()
        {
              return _context.TipoSexo != null ? 
                          View(await _context.TipoSexo.ToListAsync()) :
                          Problem("Entity set 'Contexto.TipoSexo'  is null.");
        }

        // GET: TipoSexo/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.TipoSexo == null)
            {
                return NotFound();
            }

            var tipoSexo = await _context.TipoSexo
                .FirstOrDefaultAsync(m => m.TipoSexoId == id);
            if (tipoSexo == null)
            {
                return NotFound();
            }

            return View(tipoSexo);
        }

        // GET: TipoSexo/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: TipoSexo/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("TipoSexoId,NomeTipoSexo")] TipoSexo tipoSexo)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tipoSexo);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(tipoSexo);
        }

        // GET: TipoSexo/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.TipoSexo == null)
            {
                return NotFound();
            }

            var tipoSexo = await _context.TipoSexo.FindAsync(id);
            if (tipoSexo == null)
            {
                return NotFound();
            }
            return View(tipoSexo);
        }

        // POST: TipoSexo/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("TipoSexoId,NomeTipoSexo")] TipoSexo tipoSexo)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tipoSexo);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TipoSexoExists(tipoSexo.TipoSexoId))
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
            return View(tipoSexo);
        }

        // GET: TipoSexo/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.TipoSexo == null)
            {
                return NotFound();
            }

            var tipoSexo = await _context.TipoSexo
                .FirstOrDefaultAsync(m => m.TipoSexoId == id);
            if (tipoSexo == null)
            {
                return NotFound();
            }

            return View(tipoSexo);
        }

        // POST: TipoSexo/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int TipoSexoId)
        {
            if (_context.TipoSexo == null)
            {
                return Problem("Entity set 'Contexto.TipoSexo'  is null.");
            }
            var tipoSexo = await _context.TipoSexo.FindAsync(TipoSexoId);
            if (tipoSexo != null)
            {
                _context.TipoSexo.Remove(tipoSexo);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TipoSexoExists(int id)
        {
          return (_context.TipoSexo?.Any(e => e.TipoSexoId == id)).GetValueOrDefault();
        }
    }
}
