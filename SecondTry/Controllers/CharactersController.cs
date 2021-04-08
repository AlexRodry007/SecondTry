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
    public class CharactersController : Controller
    {
        private readonly Lab1Context _context;

        public CharactersController(Lab1Context context)
        {
            _context = context;
        }

        // GET: Characters
        public async Task<IActionResult> Index()
        {
            var lab1Context = _context.Characters.Include(c => c.BattleTacticNavigation).Include(c => c.HikeNavigation).Include(c => c.WeaponeNavigation);
            return View(await lab1Context.ToListAsync());
        }

        // GET: Characters/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var character = await _context.Characters
                .Include(c => c.BattleTacticNavigation)
                .Include(c => c.HikeNavigation)
                .Include(c => c.WeaponeNavigation)
                .FirstOrDefaultAsync(m => m.TrueId == id);
            if (character == null)
            {
                return NotFound();
            }

            //return View(character);
            return RedirectToAction("Index", "Hike", new { id = character.Id, hike = character.Hike });
        }

        // GET: Characters/Create
        public IActionResult Create()
        {
            ViewData["BattleTactic"] = new SelectList(_context.Tactics, "Id", "Id");
            ViewData["Hike"] = new SelectList(_context.Hikes, "Id", "Id");
            ViewData["Weapone"] = new SelectList(_context.Items, "Id", "Id");
            return View();
        }

        // POST: Characters/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("TrueId,Name,Side,Id,MaxHealth,NowHealth,MaxEnergy,NowEnergy,MaxSatiety,NowSatiety,MaxSanity,NowSanity,Status,Strength,HeavyWeapone,ResourceGather,Carrying,HandToHand,Bruteforce,Dexterity,LightWeapone,RangedWeapone,Sneak,Dodge,Agility,Constitution,Shield,Armour,Stamina,Health,Balance,Intelligence,MagickPower,Medicine,Cooking,Science,Craft,Memory,Willpower,MagickLevel,Languages,Learning,Logistics,Perception,Hunting,Traps,Foraging,Spotting,Pathfinding,Charisma,Persuation,Intimidation,Trade,Music,Discussion,Leadership,Command,Tactic,Strategy,Survival,Adjutant,Epathy,Lie,LieDetector,Psycology,Pacification,AnimalHandling,Weapone,Hike,BattleTactic")] Character character)
        {
            if (ModelState.IsValid)
            {
                _context.Add(character);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["BattleTactic"] = new SelectList(_context.Tactics, "Id", "Id", character.BattleTactic);
            ViewData["Hike"] = new SelectList(_context.Hikes, "Id", "Id", character.Hike);
            ViewData["Weapone"] = new SelectList(_context.Items, "Id", "Id", character.Weapone);
            return View(character);
        }

        // GET: Characters/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var character = await _context.Characters.FindAsync(id);
            if (character == null)
            {
                return NotFound();
            }
            ViewData["BattleTactic"] = new SelectList(_context.Tactics, "Id", "Id", character.BattleTactic);
            ViewData["Hike"] = new SelectList(_context.Hikes, "Id", "Id", character.Hike);
            ViewData["Weapone"] = new SelectList(_context.Items, "Id", "Id", character.Weapone);
            return View(character);
        }

        // POST: Characters/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("TrueId,Name,Side,Id,MaxHealth,NowHealth,MaxEnergy,NowEnergy,MaxSatiety,NowSatiety,MaxSanity,NowSanity,Status,Strength,HeavyWeapone,ResourceGather,Carrying,HandToHand,Bruteforce,Dexterity,LightWeapone,RangedWeapone,Sneak,Dodge,Agility,Constitution,Shield,Armour,Stamina,Health,Balance,Intelligence,MagickPower,Medicine,Cooking,Science,Craft,Memory,Willpower,MagickLevel,Languages,Learning,Logistics,Perception,Hunting,Traps,Foraging,Spotting,Pathfinding,Charisma,Persuation,Intimidation,Trade,Music,Discussion,Leadership,Command,Tactic,Strategy,Survival,Adjutant,Epathy,Lie,LieDetector,Psycology,Pacification,AnimalHandling,Weapone,Hike,BattleTactic")] Character character)
        {
            if (id != character.TrueId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(character);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CharacterExists(character.TrueId))
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
            ViewData["BattleTactic"] = new SelectList(_context.Tactics, "Id", "Id", character.BattleTactic);
            ViewData["Hike"] = new SelectList(_context.Hikes, "Id", "Id", character.Hike);
            ViewData["Weapone"] = new SelectList(_context.Items, "Id", "Id", character.Weapone);
            return View(character);
        }

        // GET: Characters/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var character = await _context.Characters
                .Include(c => c.BattleTacticNavigation)
                .Include(c => c.HikeNavigation)
                .Include(c => c.WeaponeNavigation)
                .FirstOrDefaultAsync(m => m.TrueId == id);
            if (character == null)
            {
                return NotFound();
            }

            return View(character);
        }

        // POST: Characters/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var character = await _context.Characters.FindAsync(id);
            _context.Characters.Remove(character);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CharacterExists(int id)
        {
            return _context.Characters.Any(e => e.TrueId == id);
        }
    }
}
