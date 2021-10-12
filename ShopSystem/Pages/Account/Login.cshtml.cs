using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ShopSystem.Data;
using ShopSystem.Models;

namespace ShopSystem.Pages.Account
{
    [AllowAnonymous]
    public class LoginModel : PageModel
    {
        private readonly AppDbContext Db;

        public LoginModel(AppDbContext Db)
        {
            this.Db = Db;
        }

        [BindProperty]
        public InputModel Input { get; set; }
        public string ReturnUrl { get; set; }

        public class InputModel
        {
            [Required]
            public int CustomerNo { get; set; }
            [Required]
            [DataType(DataType.Password)]
            public string Password { get; set; }
        }
        public async Task OnGetAsync(string returnUrl = null)
        {
            returnUrl ??= Url.Content("~/");
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);

                ReturnUrl = returnUrl;
        }

        public async Task<IActionResult> OnPostAsync(string returnUrl = null)
        {
            returnUrl ??= Url.Content("~/");
            
            if (ModelState.IsValid)
            {
                var idAddress =  Db.Addresses.FindAsync(Input.CustomerNo).Result;
                var user = Db.Customers.Where(c => c.Password == Input.Password && c.AddressId == idAddress.Id).FirstOrDefault();
                
                if (user == null)
                {
                    ModelState.AddModelError(string.Empty, "Ungültiger Nutzername oder Kennwort.");
                    return Page();
                }
                
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.NameIdentifier, idAddress.Id.ToString()),
                    new Claim(ClaimTypes.Name,idAddress.CustomerNo.ToString()),

                };

                var identity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                var principal = new ClaimsPrincipal(identity);

                await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme,
                                                principal,
                                                new AuthenticationProperties { IsPersistent = true });

                   
               

                return LocalRedirect(returnUrl);
            }
            return Page();
        }
      
    }
}

















