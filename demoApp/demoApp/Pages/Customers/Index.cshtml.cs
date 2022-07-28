using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using demoApp.Data;
using demoApp.Models;

namespace demoApp.Pages.Customers
{
    public class IndexModel : PageModel
    {
        private readonly demoApp.Data.demoAppContext _context;

        public IndexModel(demoApp.Data.demoAppContext context)
        {
            _context = context;
        }

        public IList<Customer> Customer { get;set; } = default!;

        [BindProperty(SupportsGet = true)]
        public string? SearchString { get; set; }
        public SelectList? LastNames { get; set; }
        [BindProperty(SupportsGet = true)]
        public string? LastName { get; set; }


        public async Task OnGetAsync()
        {
                var customers = from c in _context.Customer
                             select c;
                if (!string.IsNullOrEmpty(SearchString))
                {
                    customers = customers.Where(s => s.LastName.Contains(SearchString));
                }

                Customer = await customers.ToListAsync();


            if (_context.Customer != null)
            {
                Customer = await _context.Customer.ToListAsync();
            }
        }
    }
}
