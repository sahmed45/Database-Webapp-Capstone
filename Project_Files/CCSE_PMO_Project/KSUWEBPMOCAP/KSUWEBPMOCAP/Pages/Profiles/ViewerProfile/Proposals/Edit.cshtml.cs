﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using KSUWEBPMOCAP.Data;

namespace KSUWEBPMOCAP.Pages.Profiles.ViewerProfile.Proposals
{
    public class EditModel : PageModel
    {
        private readonly KSUWEBPMOCAPContext _context;

        public EditModel(KSUWEBPMOCAPContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Proposal Proposal { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Proposal = await _context.Proposal.FirstOrDefaultAsync(m => m.Propasal_ID == id);

            if (Proposal == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Proposal).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProposalExists(Proposal.Propasal_ID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool ProposalExists(int id)
        {
            return _context.Proposal.Any(e => e.Propasal_ID == id);
        }
    }
}
