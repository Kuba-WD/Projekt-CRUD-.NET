using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using PROJEKT.Models;
using System.Threading.Tasks;

namespace PROJEKT.Pages.Products
{
    [Authorize(Roles = "Admin, Manager, Employee")]
    public class DetailsModel : PageModel
    {
        private readonly PROJEKT.Data.ProjektContext _context;

        public DetailsModel(PROJEKT.Data.ProjektContext context)
        {
            _context = context;
        }

        public Product Product { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Product = await _context.Product
                .Include(p => p.Category).FirstOrDefaultAsync(m => m.Id == id);

            if (Product == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
