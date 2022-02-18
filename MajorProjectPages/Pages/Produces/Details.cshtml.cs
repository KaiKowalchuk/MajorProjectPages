using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MajorProjectPages.Data;
using MajorProjectPages.Models;

namespace MajorProjectPages.Pages.Produces
{
    public class DetailsModel : PageModel
    {
        private readonly MajorProjectPages.Data.MajorProjectPagesContext _context;

        public DetailsModel(MajorProjectPages.Data.MajorProjectPagesContext context)
        {
            _context = context;
        }

        public Produce Produce { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Produce = await _context.Produce
                .Include(p => p.AisleObj)
                .Include(p => p.CategoryObj).FirstOrDefaultAsync(m => m.ProduceID == id);

            if (Produce == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
