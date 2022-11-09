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
    public class IndexModel : PageModel
    {
        private readonly PROJEKT.Data.ProjektContext _context;

        public IndexModel(PROJEKT.Data.ProjektContext context)
        {
            _context = context;
        }

        public IList<SiteUser> SiteUser { get;set; }

        public async Task OnGetAsync()
        {
            SiteUser = await _context.SiteUser.ToListAsync();
        }
    }
}
