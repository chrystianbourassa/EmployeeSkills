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
    public class SubCategoriesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public SubCategoriesController(ApplicationDbContext context)
        {
            _context = context;
        }



        //Get: subcategory/Details/1       
        public async Task<IActionResult> Details(int? id)
        {

            if (id == null)
            {
                return NotFound();
            }

            var subcategory = await _context.SubCategories.Include(c => c.Category)
                .FirstOrDefaultAsync(m => m.SubCategoryID == id);
            if (subcategory == null)
            {
                return NotFound();
            }

            return View(subcategory);
        }


        public IActionResult CreateNew()
        {

            ViewBag.Categories = new SelectList(_context.Categories, "CategoryID", "Description");

            return View();
        }



        [HttpPost]
        public async Task<IActionResult> Create([Bind("Description,CategoryID")] SubCategory subCategory)
        {


            if (!ModelState.IsValid)
            {

                ViewBag.Categories = new SelectList(_context.Categories, "CategoryID", "Description");
                return View(subCategory);
            }

            await _context.AddAsync(subCategory);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));

        }



        // GET: subcategory/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {


            if (id == null)
            {
                return NotFound();
            }
            ViewBag.Categories = new SelectList(_context.Categories, "CategoryID", "Description");


            var subcategory = await _context.SubCategories.FindAsync(id);
            if (subcategory == null)
            {
                return NotFound();
            }
            return View(subcategory);
        }



        // GET: employee/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var subcategories = await _context.SubCategories 
                .FirstOrDefaultAsync(m => m.SubCategoryID  == id);
            if (subcategories == null)
            {
                return NotFound();
            }

            return View(subcategories);
        }


        // POST: employee/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var subcategories = await _context.SubCategories.FindAsync(id);
            _context.SubCategories.Remove(subcategories);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }





        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("SubCategoryID,Description,CategoryID")] SubCategory subCategory)
        {
            if (id != subCategory.SubCategoryID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                _context.Update(subCategory);
                await _context.SaveChangesAsync();

                return RedirectToAction(nameof(Index));
            }
            return View(subCategory);
        }





        public async Task<IActionResult> Index()                    
        {

            //include Categories Data in view
            var data = _context.SubCategories.Include(c => c.Category);
            return View(await data.ToListAsync());

        }
    }
}
