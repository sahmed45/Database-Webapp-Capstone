﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using KSUWEBPMOCAP.Data;

namespace KSUWEBPMOCAP.Pages.ProjectReport
{
    public class DetailsModel : PageModel
    {
        private readonly KSUWEBPMOCAPContext _context;

        public DetailsModel(KSUWEBPMOCAPContext context)
        {
            _context = context;
        }

        public Project Project { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Project = await _context.Project.FirstOrDefaultAsync(m => m.Project_ID == id);

            if (Project == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
