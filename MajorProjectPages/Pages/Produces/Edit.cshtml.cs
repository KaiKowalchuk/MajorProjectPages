using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MajorProjectPages.Data;
using MajorProjectPages.Models;

namespace MajorProjectPages.Pages.Produces
{
    public class EditModel : PageModel
    {
        private readonly MajorProjectPages.Data.MajorProjectPagesContext _context;

        public EditModel(MajorProjectPages.Data.MajorProjectPagesContext context)
        {
            _context = context;
        }

        [BindProperty]
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
           ViewData["AisleID"] = new SelectList(_context.Aisle, "AisleID", "AisleID");
           ViewData["CategoryID"] = new SelectList(_context.Category, "CategoryID", "CategoryID");
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Produce).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProduceExists(Produce.ProduceID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool ProduceExists(int id)
        {
            return _context.Produce.Any(e => e.ProduceID == id);
        }
    }
}
