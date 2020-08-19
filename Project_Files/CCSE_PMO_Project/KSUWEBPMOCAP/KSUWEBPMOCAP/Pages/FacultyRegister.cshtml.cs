using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using KSUWEBPMOCAP.Models;

namespace KSUWEBPMOCAP.Pages
{
    public class FacultyRegisterModel : PageModel
    {
        [BindProperty]
        public AdminAccount account { get; set; }

        private DatabaseContext db;

        public FacultyRegisterModel(DatabaseContext _db)
        {
            db = _db;
        }
        public void OnGet()
        {
            account = new AdminAccount();
        }
        public IActionResult OnPost()
        {
            account.Faculty_Password = BCrypt.Net.BCrypt.HashPassword(account.Faculty_Password);
            db.AdminAccounts.Add(account);
            db.SaveChanges();
            return RedirectToPage("index");
        }
    }
}