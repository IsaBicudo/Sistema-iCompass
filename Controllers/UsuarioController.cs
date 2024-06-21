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
    public class UsuarioController : Controller
    {
        private readonly Contexto _context;

        public UsuarioController(Contexto context)
        {
            _context = context;
        }

        // GET: Usuario
        public async Task<IActionResult> Index()
        {
            var contexto = _context.Usuario.Include(u => u.Plano).Include(u => u.TipoSexo).Include(u => u.TipoUsuario);
            return View(await contexto.ToListAsync());
        }

        // GET: Usuario/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Usuario == null)
            {
                return NotFound();
            }

            var usuario = await _context.Usuario
                .Include(u => u.Plano)
                .Include(u => u.TipoSexo)
                .Include(u => u.TipoUsuario)
                .FirstOrDefaultAsync(m => m.UsuarioId == id);
            if (usuario == null)
            {
                return NotFound();
            }

            return View(usuario);
        }

        // GET: Usuario/Create
        public IActionResult Create()
        {
            ViewData["PlanoId"] = new SelectList(_context.Plano, "PlanoId", "NomePlano");
            ViewData["TipoSexoId"] = new SelectList(_context.TipoSexo, "TipoSexoId", "NomeTipoSexo");
            ViewData["TipoUsuarioId"] = new SelectList(_context.TipoUsuario, "TipoUsuarioId", "NomeTipoUsuario");
            return View();
        }

        // POST: Usuario/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("UsuarioId,NomeUsuario,IdadeUsuario,TipoSexoId,CpfUsuario,EnderecoUsuario,TelefoneUsuario,TipoUsuarioId,PlanoId,EmailUsuario,SenhaUsuario,ConfirmarSenhaUsuario,BiografiaUsuario, FotoUsuario")] Usuario usuario)
        {
            if (ModelState.IsValid)
            {
                _context.Add(usuario);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["PlanoId"] = new SelectList(_context.Plano, "PlanoId", "NomePlano", usuario.PlanoId);
            ViewData["TipoSexoId"] = new SelectList(_context.TipoSexo, "TipoSexoId", "NomeTipoSexo", usuario.TipoSexoId);
            ViewData["TipoUsuarioId"] = new SelectList(_context.TipoUsuario, "TipoUsuarioId", "NomeTipoUsuario", usuario.TipoUsuarioId);
            return View(usuario);
        }

        // GET: Usuario/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Usuario == null)
            {
                return NotFound();
            }

            var usuario = await _context.Usuario.FindAsync(id);
            if (usuario == null)
            {
                return NotFound();
            }
            ViewData["PlanoId"] = new SelectList(_context.Plano, "PlanoId", "NomePlano", usuario.PlanoId);
            ViewData["TipoSexoId"] = new SelectList(_context.TipoSexo, "TipoSexoId", "NomeTipoSexo", usuario.TipoSexoId);
            ViewData["TipoUsuarioId"] = new SelectList(_context.TipoUsuario, "TipoUsuarioId", "NomeTipoUsuario", usuario.TipoUsuarioId);
            return View(usuario);
        }

        // POST: Usuario/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("UsuarioId,NomeUsuario,IdadeUsuario,TipoSexoId,CpfUsuario,EnderecoUsuario,TelefoneUsuario,TipoUsuarioId,PlanoId,EmailUsuario,SenhaUsuario,ConfirmarSenhaUsuario, BiografiaUsuario, FotoUsuario")] Usuario usuario)
        {
            if (id != usuario.UsuarioId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(usuario);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UsuarioExists(usuario.UsuarioId))
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
            ViewData["PlanoId"] = new SelectList(_context.Plano, "PlanoId", "NomePlano", usuario.PlanoId);
            ViewData["TipoSexoId"] = new SelectList(_context.TipoSexo, "TipoSexoId", "NomeTipoSexo", usuario.TipoSexoId);
            ViewData["TipoUsuarioId"] = new SelectList(_context.TipoUsuario, "TipoUsuarioId", "NomeTipoUsuario", usuario.TipoUsuarioId);
            return View(usuario);
        }

        // GET: Usuario/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Usuario == null)
            {
                return NotFound();
            }

            var usuario = await _context.Usuario
                .Include(u => u.Plano)
                .Include(u => u.TipoSexo)
                .Include(u => u.TipoUsuario)
                .FirstOrDefaultAsync(m => m.UsuarioId == id);
            if (usuario == null)
            {
                return NotFound();
            }

            return View(usuario);
        }

        // POST: Usuario/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Usuario == null)
            {
                return Problem("Entity set 'Contexto.Usuario'  is null.");
            }
            var usuario = await _context.Usuario.FindAsync(id);
            if (usuario != null)
            {
                _context.Usuario.Remove(usuario);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool UsuarioExists(int id)
        {
          return (_context.Usuario?.Any(e => e.UsuarioId == id)).GetValueOrDefault();
        }
        public IActionResult Login(Usuario usuario)
        {
            if (usuario.EmailUsuario == "" || usuario.EmailUsuario == null)
            {
                return View();
            }
            else
            {
                var verificaUsuario = _context.Usuario
                    .Where(x => x.EmailUsuario == usuario.EmailUsuario && x.SenhaUsuario == usuario.SenhaUsuario)
                    .FirstOrDefault();
                if (verificaUsuario == null)
                {
                    ViewBag.Mensagem = "Usuário ou Senha inválidos!! Tente Novamente.";
                    return View();
                }
                else
                {
                    return View("~/Views/Home/Index.cshtml");
                }
            }
        }
    }
}
