using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using GamaExamBackend.Models;

namespace GamaExamBackend.Controllers
{
    public class DCreatorsController : Controller
    {
        private readonly DBExamContext _context;

        public DCreatorsController(DBExamContext context)
        {
            _context = context;
        }

        // GET: DCreators
        public async Task<IActionResult> Index()
        {
            return View(await _context.dCreators.ToListAsync());
        }

        // GET: DCreators/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dCreator = await _context.dCreators
                .FirstOrDefaultAsync(m => m.Id == id);
            if (dCreator == null)
            {
                return NotFound();
            }

            return View(dCreator);
        }

        // GET: DCreators/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: DCreators/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,username,name,password,institute")] DCreator dCreator)
        {
            if (ModelState.IsValid)
            {
                _context.Add(dCreator);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(dCreator);
        }

        // GET: DCreators/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dCreator = await _context.dCreators.FindAsync(id);
            if (dCreator == null)
            {
                return NotFound();
            }
            return View(dCreator);
        }

        // POST: DCreators/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,username,name,password,institute")] DCreator dCreator)
        {
            if (id != dCreator.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(dCreator);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DCreatorExists(dCreator.Id))
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
            return View(dCreator);
        }

        // GET: DCreators/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dCreator = await _context.dCreators
                .FirstOrDefaultAsync(m => m.Id == id);
            if (dCreator == null)
            {
                return NotFound();
            }

            return View(dCreator);
        }

        // POST: DCreators/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var dCreator = await _context.dCreators.FindAsync(id);
            _context.dCreators.Remove(dCreator);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DCreatorExists(int id)
        {
            return _context.dCreators.Any(e => e.Id == id);
        }
    }
}
