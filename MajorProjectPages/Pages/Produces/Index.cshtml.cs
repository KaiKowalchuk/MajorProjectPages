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
    public class IndexModel : PageModel
    {
        private readonly MajorProjectPages.Data.MajorProjectPagesContext _context;

        public IndexModel(MajorProjectPages.Data.MajorProjectPagesContext context)
        {
            _context = context;
        }

        public IList<Produce> Produce { get;set; }

        public async Task OnGetAsync()
        {
            Produce = await _context.Produce
                .Include(p => p.AisleObj)
                .Include(p => p.CategoryObj).ToListAsync();
        }
    }
}
