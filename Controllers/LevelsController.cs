using EmployeeSkill.Data;
using EmployeeSkill.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeSkill.Controllers
{
    public class LevelsController : Controller
    {

        private readonly ApplicationDbContext _context;

        public LevelsController(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var data = await _context.Levels.ToListAsync();
            return View(data);
        }


        public IActionResult CreateNew()
        {
            return View();
        }
        public async Task<IActionResult> Create([Bind("Description")] Level level)
        {
            if (!ModelState.IsValid) return View(level);
            await _context.AddAsync(level);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
            //return View(category);
        }

        //Get: Level/Details/1
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var level = await _context.Levels
                .FirstOrDefaultAsync(m => m.LevelID == id);
            if (level == null)
            {
                return NotFound();
            }

            return View(level);
        }



        // GET: category/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var level = await _context.Levels
                .FirstOrDefaultAsync(m => m.LevelID == id);
            if (level == null)
            {
                return NotFound();
            }

            return View(level);
        }


        // POST: category/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var level = await _context.Levels.FindAsync(id);
            _context.Levels.Remove(level);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }



        // GET: category/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var level = await _context.Levels.FindAsync(id);
            if (level == null)
            {
                return NotFound();
            }
            return View(level);
        }



        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("LevelID,Description")] Level level)
        {
            if (id != level.LevelID )
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                _context.Update(level);
                await _context.SaveChangesAsync();

                return RedirectToAction(nameof(Index));
            }
            return View(level);
        }




    }
}
