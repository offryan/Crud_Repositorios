using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Crud_MVC.Data;
using Crud_MVC.Models;

namespace Crud_MVC.Controllers
{
    public class RepositoriosController : Controller
    {
        private readonly Banco _context;

        public RepositoriosController(Banco context)
        {
            _context = context;
        }

        // GET: Repositorios
        public async Task<IActionResult> Index()
        {
              return _context.RepositoriosModel != null ? 
                          View(await _context.RepositoriosModel.ToListAsync()) :
                          Problem("Entity set 'Banco.RepositoriosModel'  is null.");
        }

        // GET: Repositorios/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.RepositoriosModel == null)
            {
                return NotFound();
            }

            var repositoriosModel = await _context.RepositoriosModel
                .FirstOrDefaultAsync(m => m.Id == id);
            if (repositoriosModel == null)
            {
                return NotFound();
            }

            return View(repositoriosModel);
        }

        // GET: Repositorios/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Repositorios/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Dono,Repositorio,Descricao,Linguagem,UltimoUpdate")] RepositoriosModel repositoriosModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(repositoriosModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(repositoriosModel);
        }

        // GET: Repositorios/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.RepositoriosModel == null)
            {
                return NotFound();
            }

            var repositoriosModel = await _context.RepositoriosModel.FindAsync(id);
            if (repositoriosModel == null)
            {
                return NotFound();
            }
            return View(repositoriosModel);
        }

        // POST: Repositorios/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Dono,Repositorio,Descricao,Linguagem,UltimoUpdate")] RepositoriosModel repositoriosModel)
        {
            if (id != repositoriosModel.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(repositoriosModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RepositoriosModelExists(repositoriosModel.Id))
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
            return View(repositoriosModel);
        }

        // GET: Repositorios/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.RepositoriosModel == null)
            {
                return NotFound();
            }

            var repositoriosModel = await _context.RepositoriosModel
                .FirstOrDefaultAsync(m => m.Id == id);
            if (repositoriosModel == null)
            {
                return NotFound();
            }

            return View(repositoriosModel);
        }

        // POST: Repositorios/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.RepositoriosModel == null)
            {
                return Problem("Entity set 'Banco.RepositoriosModel'  is null.");
            }
            var repositoriosModel = await _context.RepositoriosModel.FindAsync(id);
            if (repositoriosModel != null)
            {
                _context.RepositoriosModel.Remove(repositoriosModel);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RepositoriosModelExists(int id)
        {
          return (_context.RepositoriosModel?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
