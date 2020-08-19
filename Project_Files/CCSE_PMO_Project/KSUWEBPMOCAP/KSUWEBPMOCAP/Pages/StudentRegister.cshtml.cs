using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using KSUWEBPMOCAP.Models;

namespace KSUWEBPMOCAP.Pages
{
    public class StudentRegisterModel : PageModel
    {
        [BindProperty]
        public UserAccount account { get; set; }

        private DatabaseContext db;

        public StudentRegisterModel(DatabaseContext _db)
        {
            db = _db;
        }
        public void OnGet()
        {
            account = new UserAccount();
        }
        public IActionResult OnPost()
        {
            account.Student_Password = BCrypt.Net.BCrypt.HashPassword(account.Student_Password);
            db.UserAccounts.Add(account);
            db.SaveChanges();
            return RedirectToPage("index");
        }
    }
}