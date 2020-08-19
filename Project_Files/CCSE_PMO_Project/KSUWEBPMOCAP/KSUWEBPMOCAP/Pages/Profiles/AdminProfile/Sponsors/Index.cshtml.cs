using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using KSUWEBPMOCAP.Data;

namespace KSUWEBPMOCAP.Pages.Profiles.AdminProfile.Sponsors
{
    public class IndexModel : PageModel
    {
        private readonly KSUWEBPMOCAPContext _context;

        public IndexModel(KSUWEBPMOCAPContext context)
        {
            _context = context;
        }
        public string SponsorSort { get; set; }
        public string OrgSort { get; set; }
        public string EmailSort { get; set; }
        public string WebSort { get; set; }
        public string PhoneSort { get; set; }
        public string TitleSort { get; set; }
        public string CurrentFilter { get; set; }
        public string CurrentSort { get; set; }


        //public IList<Project> Projects { get; set; }
        public PaginatedList<Sponsor> Sponsors { get; set; }
        public List<Sponsor> Sponsor { get; private set; }

        public async Task OnGetAsync(string sortOrder, string searchString, int? pageIndex, string CurrentFilter)

        {
            CurrentSort = sortOrder;

            OrgSort = String.IsNullOrEmpty(sortOrder) ? "OrGName" : "";
            WebSort = sortOrder == "Website" ? "Web_Ascending" : " ";
            PhoneSort = sortOrder == "PhoneSort" ? "PhoneSort_DESC" : "";
            TitleSort = sortOrder == "Title_Sort" ? " Tile_Desc_Sort" : "";
            SponsorSort = sortOrder == "Sponsorsort" ? " Sponsor_Desc_Sort" : "";
            CurrentFilter = searchString;
            if (searchString != null)
            {
                pageIndex = 1;
            }
            else
            {
                searchString = CurrentFilter;
            }

            IQueryable<Sponsor> sponsorsIQ = from s in _context.Sponsor select s;
            if (!String.IsNullOrEmpty(searchString))
            {
                sponsorsIQ = sponsorsIQ.Where(s => s.Sponsor_Name.Contains(searchString)
                                       || s.Sponsor_Org.Contains(searchString) || s.Sponsor_Website.Contains(searchString));
            }


            switch (sortOrder)
            {
                case "OrGNAME":
                    sponsorsIQ = sponsorsIQ.OrderByDescending(s => s.Sponsor_Org);
                    break;
                case "website":
                    sponsorsIQ = sponsorsIQ.OrderBy(s => s.Sponsor_Website);
                    break;

                case "PhoneSort":
                    sponsorsIQ = sponsorsIQ.OrderBy(s => s.Sponsor_Phone);
                    break;
                case " TypeSort_DESC":
                    sponsorsIQ = sponsorsIQ.OrderByDescending(s => s.Sponsor_Phone);
                    break;
                case "Sponsorsort":
                    sponsorsIQ = sponsorsIQ.OrderBy(s => s.Sponsor_Name);
                    break;
                case " Department_Desc_Sortc_Sort":
                    sponsorsIQ = sponsorsIQ.OrderByDescending(s => s.Sponsor_Name);
                    break;
                default:
                    sponsorsIQ = sponsorsIQ.OrderBy(s => s.Sponsor_Name);
                    break;
            }

           // Sponsor = await sponsorsIQ.AsNoTracking().ToListAsync();
            int pageSize = 5;
            Sponsors = await PaginatedList<Sponsor>.CreateAsync(
                sponsorsIQ.AsNoTracking(), pageIndex ?? 1, pageSize);
        }
    }
}

