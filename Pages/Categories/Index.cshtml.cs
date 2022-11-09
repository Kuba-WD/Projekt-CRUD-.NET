using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using PROJEKT.Models;

namespace PROJEKT.Pages.Categories
{
    [Authorize(Roles = "Admin, Manager, Employee")]
    public class IndexModel : PageModel
    {
        private readonly PROJEKT.Data.ProjektContext _context;

        public IndexModel(PROJEKT.Data.ProjektContext context)
        {
            _context = context;
        }

        public IList<Category> Category { get;set; }

        public async Task OnGetAsync()
        {
            Category = await _context.Category.ToListAsync();
        }
    }
}
