using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using PROJEKT.Data;
using PROJEKT.Models;

namespace PROJEKT.Pages.SiteUsers
{
    [Authorize(Roles = "Admin")]
    public class CreateModel : PageModel
    {
        private readonly PROJEKT.Data.ProjektContext _context;

        public CreateModel(PROJEKT.Data.ProjektContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public SiteUser SiteUser { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            SiteUser.Password = SiteUser.HashPassword(SiteUser.Password);

            _context.SiteUser.Add(SiteUser);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
