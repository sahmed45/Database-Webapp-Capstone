using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using KSUWEBPMOCAP.Models;

namespace KSUWEBPMOCAP.Pages
{
    public class SponsorRegisterModel : PageModel
    {
        [BindProperty]
        public ViewerAccount account { get; set; }

        private DatabaseContext db;

        public SponsorRegisterModel(DatabaseContext _db)
        {
            db = _db;
        }
        public void OnGet()
        {
            account = new ViewerAccount();
        }
        public IActionResult OnPost()
        {
            account.Sponsor_Password = BCrypt.Net.BCrypt.HashPassword(account.Sponsor_Password);
            db.ViewerAccounts.Add(account);
            db.SaveChanges();
            return RedirectToPage("index");
        }
    }
}