using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ShopSystem.Data;
using ShopSystem.Models;

namespace ShopSystem.Pages.Account
{
    public class RegisterModel : PageModel
    {
        private readonly AppDbContext Db;
        public RegisterModel(AppDbContext Db)
        {
            this.Db = Db;
        }

        [BindProperty]
        public InputModel Input { get; set; }
        public string ReturnUrl { get; set; }

        public IList<AuthenticationScheme>ExternalLogins { get; set; }
        public class InputModel
        {
            [Required]
            [Display(Name="CustomerNo")]
            public int CustomerNo { get; set; }

            [Required]
            [DataType(DataType.Password)]
            [Display(Name ="Password")]
            public string Password { get; set; }

            [DataType(DataType.Password)]
            [Display(Name ="ConfirmPassword")]
            [Compare("Password",ErrorMessage = "The password and confirmation password do not match.")]
            public string ConfirmPassword { get; set; }
        }


       public async Task OnGetAsync(string returnUrl = null)
       {
            returnUrl ??= Url.Content("~/");

            if(ModelState.IsValid)
            {
                var user = Db.Addresses.Where(f => f.CustomerNo == Input.CustomerNo).FirstOrDefault();
                if(user != null)
                {
                    ModelState.AddModelError(string.Empty, Input.CustomerNo + "Already exists.");
                }
                else
                {
                    user = new Address(); 
                }
            }
       }
    }
}
