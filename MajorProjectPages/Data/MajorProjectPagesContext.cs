using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MajorProjectPages.Models;

namespace MajorProjectPages.Data
{
    public class MajorProjectPagesContext : DbContext
    {
        public MajorProjectPagesContext (DbContextOptions<MajorProjectPagesContext> options)
            : base(options)
        {
        }

        public DbSet<MajorProjectPages.Models.Aisle> Aisle { get; set; }

        public DbSet<MajorProjectPages.Models.Category> Category { get; set; }

        public DbSet<MajorProjectPages.Models.Employee> Employee { get; set; }

        public DbSet<MajorProjectPages.Models.Position> Position { get; set; }

        public DbSet<MajorProjectPages.Models.Produce> Produce { get; set; }
    }
}
