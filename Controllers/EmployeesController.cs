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
    public class EmployeesController : Controller
    {

        private readonly ApplicationDbContext _context;

        public EmployeesController(ApplicationDbContext context)
        {
            _context = context;
        }


        //Get: employee/Details/1
        // GET: employee/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            //ViewBag.Cities = new SelectList(_context.Cities, "CityID", "Name");


            if (id == null)
            {
                return NotFound();
            }

            var category = await _context.Employees.Include(c => c.City)
                .FirstOrDefaultAsync(m => m.EmployeeID  == id);
            if (category == null)
            {
                return NotFound();
            }

            return View(category);
        }



        // GET: employee/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var  employee  = await _context.Employees
                .FirstOrDefaultAsync(m => m.EmployeeID  == id);
            if (employee == null)
            {
                return NotFound();
            }

            return View(employee);
        }


        // POST: employee/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var employee = await _context.Employees.FindAsync(id);
            _context.Employees.Remove(employee);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }




        // GET: employee/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {


            if (id == null)
            {
                return NotFound();
            }
            ViewBag.Cities = new SelectList(_context.Cities, "CityID", "Name");


            var employee = await _context.Employees.FindAsync(id);
            if (employee == null)
            {
                return NotFound();
            }
            return View(employee);
        }



        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("EmployeeID,FullName,BirthDate,HireDate,Address,PostalCode, Country,HomePhone,Notes,ResumePath,CityID")] Employee employee )
        {
            if (id != employee.EmployeeID )
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                _context.Update(employee);
                await _context.SaveChangesAsync();

                return RedirectToAction(nameof(Index));
            }
            return View(employee);
        }


        public IActionResult CreateNew()
        {

            ViewBag.Cities = new SelectList(_context.Cities , "CityID", "Name");

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create([Bind("FullName,BirthDate,HireDate,Address,PostalCode, Country,HomePhone,Notes,ResumePath,CityID")] Employee  employee )
        {
            if (!ModelState.IsValid)
            {

                ViewBag.Cities = new SelectList(_context.Cities , "CityID", "Name");
                return View(employee );
            }

            await _context.AddAsync(employee);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));

        }






        public async Task<IActionResult> Index()
        {

            //include Categories Data in view
            var data = _context.Employees.Include(c => c.City  );
            return View(await data.ToListAsync());
        }
    }
}
