using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MajorProjectPages.Data;
using MajorProjectPages.Models;

namespace MajorProjectPages.Pages.Positions
{
    public class DetailsModel : PageModel
    {
        private readonly MajorProjectPages.Data.MajorProjectPagesContext _context;

        public DetailsModel(MajorProjectPages.Data.MajorProjectPagesContext context)
        {
            _context = context;
        }

        public Position Position { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Position = await _context.Position.FirstOrDefaultAsync(m => m.PositionID == id);

            if (Position == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
