using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MajorProjectPages.Data;
using MajorProjectPages.Models;

namespace MajorProjectPages.Pages.Employees
{
    public class DetailsModel : PageModel
    {
        private readonly MajorProjectPages.Data.MajorProjectPagesContext _context;

        public DetailsModel(MajorProjectPages.Data.MajorProjectPagesContext context)
        {
            _context = context;
        }

        public Employee Employee { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Employee = await _context.Employee
                .Include(e => e.PositionObj).FirstOrDefaultAsync(m => m.EmployeeID == id);

            if (Employee == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
