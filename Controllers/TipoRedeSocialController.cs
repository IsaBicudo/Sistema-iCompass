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
    public class TipoRedeSocialController : Controller
    {
        private readonly Contexto _context;

        public TipoRedeSocialController(Contexto context)
        {
            _context = context;
        }

        // GET: TipoRedeSocial
        public async Task<IActionResult> Index()
        {
              return _context.TipoRedeSocial != null ? 
                          View(await _context.TipoRedeSocial.ToListAsync()) :
                          Problem("Entity set 'Contexto.TipoRedeSocial'  is null.");
        }

        // GET: TipoRedeSocial/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.TipoRedeSocial == null)
            {
                return NotFound();
            }

            var tipoRedeSocial = await _context.TipoRedeSocial
                .FirstOrDefaultAsync(m => m.TipoRedeSocialId == id);
            if (tipoRedeSocial == null)
            {
                return NotFound();
            }

            return View(tipoRedeSocial);
        }

        // GET: TipoRedeSocial/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: TipoRedeSocial/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("TipoRedeSocialId,NomeTipoRedeSocial")] TipoRedeSocial tipoRedeSocial)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tipoRedeSocial);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(tipoRedeSocial);
        }

        // GET: TipoRedeSocial/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.TipoRedeSocial == null)
            {
                return NotFound();
            }

            var tipoRedeSocial = await _context.TipoRedeSocial.FindAsync(id);
            if (tipoRedeSocial == null)
            {
                return NotFound();
            }
            return View(tipoRedeSocial);
        }

        // POST: TipoRedeSocial/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("TipoRedeSocialId,NomeTipoRedeSocial")] TipoRedeSocial tipoRedeSocial)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tipoRedeSocial);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TipoRedeSocialExists(tipoRedeSocial.TipoRedeSocialId))
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
            return View(tipoRedeSocial);
        }

        // GET: TipoRedeSocial/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.TipoRedeSocial == null)
            {
                return NotFound();
            }

            var tipoRedeSocial = await _context.TipoRedeSocial
                .FirstOrDefaultAsync(m => m.TipoRedeSocialId == id);
            if (tipoRedeSocial == null)
            {
                return NotFound();
            }

            return View(tipoRedeSocial);
        }

        // POST: TipoRedeSocial/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int TipoRedeSocialId)
        {
            if (_context.TipoRedeSocial == null)
            {
                return Problem("Entity set 'Contexto.TipoRedeSocial'  is null.");
            }
            var tipoRedeSocial = await _context.TipoRedeSocial.FindAsync(TipoRedeSocialId);
            if (tipoRedeSocial != null)
            {
                _context.TipoRedeSocial.Remove(tipoRedeSocial);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TipoRedeSocialExists(int id)
        {
          return (_context.TipoRedeSocial?.Any(e => e.TipoRedeSocialId == id)).GetValueOrDefault();
        }
    }
}
