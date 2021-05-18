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

    public class DParticipantsController : Controller
    {
        private readonly DBExamContext _context;

        public DParticipantsController(DBExamContext context)
        {
            _context = context;
        }

        // GET: DParticipants
        public async Task<IActionResult> Index()
        {
            return View(await _context.dParticipants.ToListAsync());
        }

        // GET: DParticipants/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dParticipant = await _context.dParticipants
                .FirstOrDefaultAsync(m => m.Id == id);
            if (dParticipant == null)
            {
                return NotFound();
            }

            return View(dParticipant);
        }

        // GET: DParticipants/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: DParticipants/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,username,name,password,institute")] DParticipant dParticipant)
        {
            if (ModelState.IsValid)
            {
                _context.Add(dParticipant);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(dParticipant);
        }

        // GET: DParticipants/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dParticipant = await _context.dParticipants.FindAsync(id);
            if (dParticipant == null)
            {
                return NotFound();
            }
            return View(dParticipant);
        }

        // POST: DParticipants/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,username,name,password,institute")] DParticipant dParticipant)
        {
            if (id != dParticipant.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(dParticipant);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DParticipantExists(dParticipant.Id))
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
            return View(dParticipant);
        }

        // GET: DParticipants/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dParticipant = await _context.dParticipants
                .FirstOrDefaultAsync(m => m.Id == id);
            if (dParticipant == null)
            {
                return NotFound();
            }

            return View(dParticipant);
        }

        // POST: DParticipants/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var dParticipant = await _context.dParticipants.FindAsync(id);
            _context.dParticipants.Remove(dParticipant);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DParticipantExists(int id)
        {
            return _context.dParticipants.Any(e => e.Id == id);
        }
    }
}
