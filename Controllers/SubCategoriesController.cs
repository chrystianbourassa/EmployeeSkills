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



        public async Task<IActionResult> Index()                    
        {

            //include Categories Data in view
            var data = _context.SubCategories.Include(c => c.Category);
            return View(await data.ToListAsync());

        }
    }
}
