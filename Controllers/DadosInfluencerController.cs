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
    public class DadosInfluencerController : Controller
    {
        private readonly Contexto _context;

        public DadosInfluencerController(Contexto context)
        {
            _context = context;
        }

        // GET: DadosInfluencer
        public async Task<IActionResult> Index()
        {
              return _context.DadosInfluencer != null ? 
                          View(await _context.DadosInfluencer.ToListAsync()) :
                          Problem("Entity set 'Contexto.DadosInfluencer'  is null.");
        }

        // GET: DadosInfluencer/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.DadosInfluencer == null)
            {
                return NotFound();
            }

            var dadosInfluencer = await _context.DadosInfluencer
                .FirstOrDefaultAsync(m => m.DadosInfluencerId == id);
            if (dadosInfluencer == null)
            {
                return NotFound();
            }

            return View(dadosInfluencer);
        }

        // GET: DadosInfluencer/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: DadosInfluencer/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("DadosInfluencerId,IdUsuario,IdTipoConteudo,IdTipoRedeSocial")] DadosInfluencer dadosInfluencer)
        {
            if (ModelState.IsValid)
            {
                _context.Add(dadosInfluencer);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(dadosInfluencer);
        }

        // GET: DadosInfluencer/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.DadosInfluencer == null)
            {
                return NotFound();
            }

            var dadosInfluencer = await _context.DadosInfluencer.FindAsync(id);
            if (dadosInfluencer == null)
            {
                return NotFound();
            }
            return View(dadosInfluencer);
        }

        // POST: DadosInfluencer/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("DadosInfluencerId,IdUsuario,IdTipoConteudo,IdTipoRedeSocial")] DadosInfluencer dadosInfluencer)
        {
            if (id != dadosInfluencer.DadosInfluencerId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(dadosInfluencer);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DadosInfluencerExists(dadosInfluencer.DadosInfluencerId))
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
            return View(dadosInfluencer);
        }

        // GET: DadosInfluencer/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.DadosInfluencer == null)
            {
                return NotFound();
            }

            var dadosInfluencer = await _context.DadosInfluencer
                .FirstOrDefaultAsync(m => m.DadosInfluencerId == id);
            if (dadosInfluencer == null)
            {
                return NotFound();
            }

            return View(dadosInfluencer);
        }

        // POST: DadosInfluencer/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.DadosInfluencer == null)
            {
                return Problem("Entity set 'Contexto.DadosInfluencer'  is null.");
            }
            var dadosInfluencer = await _context.DadosInfluencer.FindAsync(id);
            if (dadosInfluencer != null)
            {
                _context.DadosInfluencer.Remove(dadosInfluencer);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DadosInfluencerExists(int id)
        {
          return (_context.DadosInfluencer?.Any(e => e.DadosInfluencerId == id)).GetValueOrDefault();
        }
    }
}
