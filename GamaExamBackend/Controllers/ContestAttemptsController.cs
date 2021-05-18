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
    public class ContestAttemptsController : Controller
    {
        private readonly DBExamContext _context;

        public ContestAttemptsController(DBExamContext context)
        {
            _context = context;
        }

        // GET: ContestAttempts
        public async Task<IActionResult> Index()
        {
            var dBExamContext = _context.dContestsAttempt.Include(c => c.Contest).Include(c => c.Participant);
            return View(await dBExamContext.ToListAsync());
        }

        // GET: ContestAttempts/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var contestAttempt = await _context.dContestsAttempt
                .Include(c => c.Contest)
                .Include(c => c.Participant)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (contestAttempt == null)
            {
                return NotFound();
            }

            return View(contestAttempt);
        }

        // GET: ContestAttempts/Create
        public IActionResult Create()
        {
            ViewData["ContestId"] = new SelectList(_context.dContests, "Id", "Id");
            ViewData["ParticipantId"] = new SelectList(_context.dParticipants, "Id", "Id");
            return View();
        }

        // POST: ContestAttempts/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Answer,TimeLeft,ContestId,ParticipantId")] ContestAttempt contestAttempt)
        {
            if (ModelState.IsValid)
            {
                _context.Add(contestAttempt);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ContestId"] = new SelectList(_context.dContests, "Id", "Id", contestAttempt.ContestId);
            ViewData["ParticipantId"] = new SelectList(_context.dParticipants, "Id", "Id", contestAttempt.ParticipantId);
            return View(contestAttempt);
        }

        // GET: ContestAttempts/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var contestAttempt = await _context.dContestsAttempt.FindAsync(id);
            if (contestAttempt == null)
            {
                return NotFound();
            }
            ViewData["ContestId"] = new SelectList(_context.dContests, "Id", "Id", contestAttempt.ContestId);
            ViewData["ParticipantId"] = new SelectList(_context.dParticipants, "Id", "Id", contestAttempt.ParticipantId);
            return View(contestAttempt);
        }

        // POST: ContestAttempts/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Answer,TimeLeft,ContestId,ParticipantId")] ContestAttempt contestAttempt)
        {
            if (id != contestAttempt.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(contestAttempt);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ContestAttemptExists(contestAttempt.Id))
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
            ViewData["ContestId"] = new SelectList(_context.dContests, "Id", "Id", contestAttempt.ContestId);
            ViewData["ParticipantId"] = new SelectList(_context.dParticipants, "Id", "Id", contestAttempt.ParticipantId);
            return View(contestAttempt);
        }

        // GET: ContestAttempts/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var contestAttempt = await _context.dContestsAttempt
                .Include(c => c.Contest)
                .Include(c => c.Participant)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (contestAttempt == null)
            {
                return NotFound();
            }

            return View(contestAttempt);
        }

        // POST: ContestAttempts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var contestAttempt = await _context.dContestsAttempt.FindAsync(id);
            _context.dContestsAttempt.Remove(contestAttempt);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ContestAttemptExists(int id)
        {
            return _context.dContestsAttempt.Any(e => e.Id == id);
        }
    }
}
