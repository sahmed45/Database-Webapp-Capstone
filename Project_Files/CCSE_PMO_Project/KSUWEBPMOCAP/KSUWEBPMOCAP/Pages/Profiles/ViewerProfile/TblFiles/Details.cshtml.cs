﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using KSUWEBPMOCAP.Data;

namespace KSUWEBPMOCAP.Pages.Profiles.ViewerProfile.TblFiles
{
    public class DetailsModel : PageModel
    {
        private readonly KSUWEBPMOCAPContext _context;

        public DetailsModel(KSUWEBPMOCAPContext context)
        {
            _context = context;
        }

        public TblFile TblFile { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            TblFile = await _context.TblFile.FirstOrDefaultAsync(m => m.ID == id);

            if (TblFile == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
