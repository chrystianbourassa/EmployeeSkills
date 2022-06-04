using EmployeeSkill.Data;
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
    }
}
