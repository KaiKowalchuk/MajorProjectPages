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
    public class IndexModel : PageModel
    {
        private readonly MajorProjectPages.Data.MajorProjectPagesContext _context;

        public IndexModel(MajorProjectPages.Data.MajorProjectPagesContext context)
        {
            _context = context;
        }

        public IList<Aisle> Aisle { get;set; }

        public async Task OnGetAsync()
        {
            Aisle = await _context.Aisle.ToListAsync();
        }
    }
}
