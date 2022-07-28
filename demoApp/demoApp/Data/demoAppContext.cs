using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using demoApp.Models;

namespace demoApp.Data
{
    public class demoAppContext : DbContext
    {
        public demoAppContext (DbContextOptions<demoAppContext> options)
            : base(options)
        {
        }

        public DbSet<demoApp.Models.Customer> Customer { get; set; } = default!;
    }
}
