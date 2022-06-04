using EmployeeSkill.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeSkill.Controllers
{
    public class Employees_SkillsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public Employees_SkillsController(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var data = await _context.Employees_Skills.ToListAsync();
            return View(data);
        }
    }
}
