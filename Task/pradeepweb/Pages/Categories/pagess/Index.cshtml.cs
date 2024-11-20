using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using pradeepweb.Data;
using pradeepweb.Model;

namespace pradeepweb.Pages.Categories.pagess
{
    public class IndexModel : PageModel
    {
        private readonly pradeepweb.Data.ApplicationDbContext _context;

        public IndexModel(pradeepweb.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Category> Category { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Category = await _context.Category.ToListAsync();
        }
    }
}
