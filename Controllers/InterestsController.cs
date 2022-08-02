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
    public class InterestsController : Controller
    {

        private readonly ApplicationDbContext _context;

        public InterestsController(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var data = await _context.Interests.ToListAsync();
            return View(data);
        }

        public IActionResult CreateNew()
        {
            return View();
        }
        public async Task<IActionResult> Create([Bind("Description")] Interest interest)
        {
            if (!ModelState.IsValid) return View(interest);
            await _context.AddAsync(interest);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        //Get: Interest/Details/1
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var interest = await _context.Interests
                .FirstOrDefaultAsync(m => m.InterestID == id);
            if (interest == null)
            {
                return NotFound();
            }

            return View(interest);
        }



        // GET: category/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var interest = await _context.Interests
                .FirstOrDefaultAsync(m => m.InterestID == id);
            if (interest == null)
            {
                return NotFound();
            }

            return View(interest);
        }


        // POST: category/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var interest = await _context.Interests.FindAsync(id);
            _context.Interests.Remove(interest);
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

            var interest = await _context.Interests.FindAsync(id);
            if (interest == null)
            {
                return NotFound();
            }
            return View(interest);
        }



        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("InterestID,Description")] Interest interest)
        {
            if (id != interest.InterestID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                _context.Update(interest);
                await _context.SaveChangesAsync();

                return RedirectToAction(nameof(Index));
            }
            return View(interest);
        }


    }
}
