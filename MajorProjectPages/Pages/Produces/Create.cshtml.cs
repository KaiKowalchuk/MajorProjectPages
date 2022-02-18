using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using MajorProjectPages.Data;
using MajorProjectPages.Models;

namespace MajorProjectPages.Pages.Produces
{
    public class CreateModel : PageModel
    {
        private readonly MajorProjectPages.Data.MajorProjectPagesContext _context;

        public CreateModel(MajorProjectPages.Data.MajorProjectPagesContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["AisleID"] = new SelectList(_context.Aisle, "AisleID", "AisleName");
        ViewData["CategoryID"] = new SelectList(_context.Category, "CategoryID", "CategoryName");
            return Page();
        }

        [BindProperty]
        public Produce Produce { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Produce.Add(Produce);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
