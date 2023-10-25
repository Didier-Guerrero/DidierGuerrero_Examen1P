using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DidierGuerrero_Examen1P.Data;
using DidierGuerrero_Examen1P.Models;

namespace DidierGuerrero_Examen1P.Controllers
{
    public class dgEntradaController : Controller
    {
        private readonly DidierGuerrero_Examen1PContext _context;

        public dgEntradaController(DidierGuerrero_Examen1PContext context)
        {
            _context = context;
        }

        // GET: dgEntrada
        public async Task<IActionResult> Index()
        {
              return _context.DidierGuerrero__Tabla != null ? 
                          View(await _context.DidierGuerrero__Tabla.ToListAsync()) :
                          Problem("Entity set 'DidierGuerrero_Examen1PContext.DidierGuerrero__Tabla'  is null.");
        }

        // GET: dgEntrada/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.DidierGuerrero__Tabla == null)
            {
                return NotFound();
            }

            var didierGuerrero__Tabla = await _context.DidierGuerrero__Tabla
                .FirstOrDefaultAsync(m => m.ID == id);
            if (didierGuerrero__Tabla == null)
            {
                return NotFound();
            }

            return View(didierGuerrero__Tabla);
        }

        // GET: dgEntrada/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: dgEntrada/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,dgEntradasDisponibles,dgPrecio,dgNombrePelicula,dgFechaPelicula,MdgMayorEdad")] DidierGuerrero__Tabla didierGuerrero__Tabla)
        {
            if (ModelState.IsValid)
            {
                _context.Add(didierGuerrero__Tabla);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(didierGuerrero__Tabla);
        }

        // GET: dgEntrada/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.DidierGuerrero__Tabla == null)
            {
                return NotFound();
            }

            var didierGuerrero__Tabla = await _context.DidierGuerrero__Tabla.FindAsync(id);
            if (didierGuerrero__Tabla == null)
            {
                return NotFound();
            }
            return View(didierGuerrero__Tabla);
        }

        // POST: dgEntrada/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,dgEntradasDisponibles,dgPrecio,dgNombrePelicula,dgFechaPelicula,MdgMayorEdad")] DidierGuerrero__Tabla didierGuerrero__Tabla)
        {
            if (id != didierGuerrero__Tabla.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(didierGuerrero__Tabla);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DidierGuerrero__TablaExists(didierGuerrero__Tabla.ID))
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
            return View(didierGuerrero__Tabla);
        }

        // GET: dgEntrada/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.DidierGuerrero__Tabla == null)
            {
                return NotFound();
            }

            var didierGuerrero__Tabla = await _context.DidierGuerrero__Tabla
                .FirstOrDefaultAsync(m => m.ID == id);
            if (didierGuerrero__Tabla == null)
            {
                return NotFound();
            }

            return View(didierGuerrero__Tabla);
        }

        // POST: dgEntrada/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.DidierGuerrero__Tabla == null)
            {
                return Problem("Entity set 'DidierGuerrero_Examen1PContext.DidierGuerrero__Tabla'  is null.");
            }
            var didierGuerrero__Tabla = await _context.DidierGuerrero__Tabla.FindAsync(id);
            if (didierGuerrero__Tabla != null)
            {
                _context.DidierGuerrero__Tabla.Remove(didierGuerrero__Tabla);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DidierGuerrero__TablaExists(int id)
        {
          return (_context.DidierGuerrero__Tabla?.Any(e => e.ID == id)).GetValueOrDefault();
        }
    }
}
