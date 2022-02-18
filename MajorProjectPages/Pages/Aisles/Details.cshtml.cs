using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MajorProjectPages.Data;
using MajorProjectPages.Models;

namespace MajorProjectPages.Pages.Aisles
{
    public class DetailsModel : PageModel
    {
        private readonly MajorProjectPages.Data.MajorProjectPagesContext _context;

        public DetailsModel(MajorProjectPages.Data.MajorProjectPagesContext context)
        {
            _context = context;
        }

        public Aisle Aisle { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Aisle = await _context.Aisle.FirstOrDefaultAsync(m => m.AisleID == id);

            if (Aisle == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
