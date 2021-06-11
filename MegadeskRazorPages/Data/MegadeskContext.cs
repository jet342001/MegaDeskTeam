using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MegadeskRazorPages.Models;

namespace MegadeskRazorPages.Data
{
    public class MegadeskContext : DbContext
    {
        public MegadeskContext (DbContextOptions<MegadeskContext> options)
            : base(options)
        {
        }

        public DbSet<MegadeskRazorPages.Models.Quote> Quote { get; set; }
    }
}
