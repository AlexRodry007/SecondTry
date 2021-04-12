using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SecondTry;

namespace SecondTry.Controllers
{
    public class HikesController : Controller
    {
        private readonly Lab1Context _context;

        public HikesController(Lab1Context context)
        {
            _context = context;
        }

        // GET: Hikes
        public async Task<IActionResult> Index()
        {
            var lab1Context = _context.Hikes.Include(h => h.PathNavigation);
            return View(await lab1Context.ToListAsync());
        }

        // GET: Hikes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var hike = await _context.Hikes
                .Include(h => h.PathNavigation)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (hike == null)
            {
                return NotFound();
            }

            //return View(hike);
            return RedirectToAction("Index", "Items", new { id = hike.Id, name = hike.HikeName });
        }

        // GET: Hikes/Create
        public IActionResult Create()
        {
            ViewData["Path"] = new SelectList(_context.Paths, "Id", "Id");
            return View();
        }

        // POST: Hikes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,HikeName,Path")] Hike hike)
        {
            if (ModelState.IsValid)
            {
                _context.Add(hike);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["Path"] = new SelectList(_context.Paths, "Id", "Id", hike.Path);
            return View(hike);
        }

        // GET: Hikes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var hike = await _context.Hikes.FindAsync(id);
            if (hike == null)
            {
                return NotFound();
            }
            ViewData["Path"] = new SelectList(_context.Paths, "Id", "Id", hike.Path);
            return View(hike);
        }

        // POST: Hikes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,HikeName,Path")] Hike hike)
        {
            if (id != hike.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(hike);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!HikeExists(hike.Id))
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
            ViewData["Path"] = new SelectList(_context.Paths, "Id", "Id", hike.Path);
            return View(hike);
        }

        // GET: Hikes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var hike = await _context.Hikes
                .Include(h => h.PathNavigation)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (hike == null)
            {
                return NotFound();
            }

            return View(hike);
        }

        // POST: Hikes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var hike = await _context.Hikes.FindAsync(id);
            _context.Hikes.Remove(hike);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool HikeExists(int id)
        {
            return _context.Hikes.Any(e => e.Id == id);
        }
    }
}
