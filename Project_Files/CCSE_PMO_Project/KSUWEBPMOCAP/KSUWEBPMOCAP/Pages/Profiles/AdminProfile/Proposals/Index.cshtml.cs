using KSUWEBPMOCAP.Data;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KSUWEBPMOCAP.Pages.Profiles.AdminProfile.Proposals
{
    public class IndexModel : PageModel
    {
        private readonly KSUWEBPMOCAPContext _context;

        public IndexModel(KSUWEBPMOCAPContext context)
        {
            _context = context;
        }

        public string ProjectNumSort { get; set; }
        public string SponsorNameSort { get; set; }
        public string TypeSort { get; set; }
        public string DeptNameSort { get; set; }
        public string CurrentFilter { get; set; }
        public string CurrentSort { get; set; }


        public IList<Proposal> Proposal { get; set; }
        public PaginatedList<Proposal> Proposals { get; set; }

        public async Task OnGetAsync(string sortOrder, string searchString, int? pageIndex, string CurrentFilter)

        {
            CurrentSort = sortOrder;

            ProjectNumSort = String.IsNullOrEmpty(sortOrder) ? "ProjectNum" : string.Empty;
            SponsorNameSort = sortOrder == "SponsorName" ? "SponsorName_desc" : string.Empty;
            TypeSort = sortOrder == "TypeSort" ? "TypeSort_desc" : string.Empty;
            DeptNameSort = sortOrder == "DeptSort" ? "DeptSort_desc" : string.Empty;
            CurrentFilter = searchString;
            if (searchString != null)
            {
                pageIndex = 1;
            }
            else
            {
                searchString = CurrentFilter;
            }

            IQueryable<Proposal> ProposalsIQ = from s in _context.Proposal select s;
            if (!String.IsNullOrEmpty(searchString))
            {
                ProposalsIQ = ProposalsIQ.Where(s => s.Project_Num.Contains(searchString)
                                       || s.Project_Type.Contains(searchString) || s.Sponsor_Name.Contains(searchString)
                                       || s.Dept_Name.Contains(searchString));
            }


            switch (sortOrder)

            {
                case "ProjectNum":
                    ProposalsIQ = ProposalsIQ.OrderByDescending(s => s.Project_Num);
                    break;

                case "SponsorName_Desc":
                    ProposalsIQ = ProposalsIQ.OrderByDescending(s => s.Sponsor_Name);
                    break;
                case "sponsorName":
                    ProposalsIQ = ProposalsIQ.OrderBy(s => s.Sponsor_Name);
                    break;

                case "DeptSort":
                    ProposalsIQ = ProposalsIQ.OrderByDescending(s => s.Dept_Name);
                    break;
                case "DeptSort_desc":
                    ProposalsIQ = ProposalsIQ.OrderBy(s => s.Dept_Name);
                    break;
                default:
                    ProposalsIQ = ProposalsIQ.OrderBy(s => s.Project_Num);
                    break;
            }

            Proposal = await ProposalsIQ.AsNoTracking().ToListAsync();
            int pageSize = 5;
            Proposals = await PaginatedList<Proposal>.CreateAsync(
                ProposalsIQ.AsNoTracking(), pageIndex ?? 1, pageSize);
        }
    }
}

