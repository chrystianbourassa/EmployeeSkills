using EmployeeSkill.Data;
using EmployeeSkill.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeSkill.Controllers
{
    public class SkillsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public SkillsController(ApplicationDbContext context)
        {
            _context = context;
        }


        //--------------------------------------------------------------------------------
        // INDEX SCREEN
        //--------------------------------------------------------------------------------

        public async Task<IActionResult> Index()
        {

            //include Categories Data in view
            var data = _context.Skills.Include(c => c.Category).Include(c => c.SubCategory);


            return View(await data.ToListAsync());

        }

        //--------------------------------------------------------------------------------
        // CREATE NEW SCREEN
        //--------------------------------------------------------------------------------

        public IActionResult CreateNew()
        {

            ViewBag.Categories = new SelectList(_context.Categories, "CategoryID", "Description");
            ViewBag.SubCategories = new SelectList(_context.SubCategories, "SubCategoryID", "Description");

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create([Bind("Title,CategoryID,SubCategoryID")] Skill skill)
        {


            if (!ModelState.IsValid)
            {

                ViewBag.Categories = new SelectList(_context.Categories, "CategoryID", "Description");
                ViewBag.SubCategories = new SelectList(_context.SubCategories, "SubCategoryID", "Description");
                return View(skill);
            }

            await _context.AddAsync(skill);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));

        }


        //--------------------------------------------------------------------------------
        // VIEW DETAIL SCREEN
        //--------------------------------------------------------------------------------
        public async Task<IActionResult> Details(int? id)
        {

            if (id == null)
            {
                return NotFound();
            }

            var skill = await _context.Skills.Include(c => c.Category).Include(c => c.SubCategory)
                .FirstOrDefaultAsync(m => m.SkillID == id);
            if (skill == null)
            {
                return NotFound();
            }

            return View(skill);
        }



        //--------------------------------------------------------------------------------
        // EDIT SCREEN
        //--------------------------------------------------------------------------------

        public async Task<IActionResult> Edit(int? id)
        {


            if (id == null)
            {
                return NotFound();
            }
            ViewBag.Categories = new SelectList(_context.Categories, "CategoryID", "Description");
            ViewBag.SubCategories = new SelectList(_context.SubCategories, "SubCategoryID", "Description");


            var skill = await _context.Skills.FindAsync(id);
            if (skill == null)
            {
                return NotFound();
            }
            return View(skill);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("SkillID, Title, CategoryID, SubCategoryID")] Skill skill)
        {
            if (id != skill.SkillID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                _context.Update(skill);
                await _context.SaveChangesAsync();

                return RedirectToAction(nameof(Index));
            }
            return View(skill);
        }


        //--------------------------------------------------------------------------------
        // DELETE SCREEN
        //--------------------------------------------------------------------------------

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var skills = await _context.Skills
                .FirstOrDefaultAsync(m => m.SkillID == id);
            if (skills == null)
            {
                return NotFound();
            }

            return View(skills);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var skill = await _context.Skills.FindAsync(id);
            _context.Skills.Remove(skill);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }





    }
}
