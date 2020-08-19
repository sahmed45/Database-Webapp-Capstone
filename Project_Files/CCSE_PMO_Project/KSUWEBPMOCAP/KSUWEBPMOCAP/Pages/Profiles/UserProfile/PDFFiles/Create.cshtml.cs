﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using KSUWEBPMOCAP.Data;

namespace KSUWEBPMOCAP.Pages.Profiles.UserProfile.PDFFiles
{
    public class CreateModel : PageModel
    {
        private readonly KSUWEBPMOCAPContext _context;

        public CreateModel(KSUWEBPMOCAPContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public PDFFILE PDFFILE { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.PDFFILE.Add(PDFFILE);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}