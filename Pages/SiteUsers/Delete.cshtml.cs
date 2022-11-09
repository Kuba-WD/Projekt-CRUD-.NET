using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using PROJEKT.Data;
using PROJEKT.Models;

namespace PROJEKT.Pages.SiteUsers
{
    [Authorize(Roles = "Admin")]
    public class DeleteModel : PageModel
    {
        private readonly PROJEKT.Data.ProjektContext _context;

        public DeleteModel(PROJEKT.Data.ProjektContext context)
        {
            _context = context;
        }

        [BindProperty]
        public SiteUser SiteUser { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            SiteUser = await _context.SiteUser.FirstOrDefaultAsync(m => m.Id == id);

            if (SiteUser == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            SiteUser = await _context.SiteUser.FindAsync(id);

            if (SiteUser != null)
            {
                _context.SiteUser.Remove(SiteUser);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
