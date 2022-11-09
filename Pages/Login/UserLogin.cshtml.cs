using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using PROJEKT.Models;

namespace PROJEKT.Pages.Login
{
    public class UserLoginModel : PageModel
    {
        public string ProjektDBcs = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Projekt;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        private readonly IConfiguration _configuration;
        private int Role { get; set; } // 3 - Admin, 2 - Manager, 1 - Employee
        public string Message { get; set; }
        [BindProperty]
        public SiteUser user { get; set; }
        public UserLoginModel(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        private bool ValidateUser(SiteUser user)
        {
            SqlConnection con = new SqlConnection(ProjektDBcs);
            con.Open();

            int authorization = 0;

            string query = "SELECT Role, Password FROM[SiteUser] WHERE Username = '" + user.Username + "' AND Password = '" + SiteUser.HashPassword(user.Password) + "'";

            using (var command = new SqlCommand(query, con))
            {
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        authorization = Convert.ToInt32(reader["Role"]);
                    }
                }
            }

            if (authorization != 0)
            {
                Role = authorization; 
                return true;
            }    
            else return false;
        }

        public async Task<IActionResult> OnPostAsync(string returnUrl)
        {
            ViewData["ReturnUrl"] = returnUrl;
            if (ValidateUser(user))
            {
                var claims = new List<Claim>()
                {
                new Claim(ClaimTypes.Name, user.Username)
                };

                switch(Role)
                {
                    case 1: 
                        claims.Add(new Claim(ClaimTypes.Role, "Employee"));
                        break;
                    case 2:
                        claims.Add(new Claim(ClaimTypes.Role, "Manager"));
                        break;
                    case 3:
                        claims.Add(new Claim(ClaimTypes.Role, "Admin"));
                        break;

                    default:
                        break;
                }

                var claimsIdentity = new ClaimsIdentity(claims, "CookieAuthentication");
                await HttpContext.SignInAsync("CookieAuthentication", new
                ClaimsPrincipal(claimsIdentity));
                return RedirectToPage(returnUrl);
            }
            TempData["Error"] = "Error. Invalid Password or Username";
            return Page();
        }

        public void OnGet()
        {
        }
    }
}
