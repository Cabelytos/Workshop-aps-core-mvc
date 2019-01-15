using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace VendsWeb.Models
{
    public class VendsWebContext : DbContext
    {
        public VendsWebContext (DbContextOptions<VendsWebContext> options)
            : base(options)
        {
        }

        public DbSet<VendsWeb.Models.Department> Department { get; set; }
    }
}
