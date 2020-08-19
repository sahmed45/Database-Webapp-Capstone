using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using KSUWEBPMOCAP.Data;

namespace KSUWEBPMOCAP.Pages.Profiles.AdminProfile.Projects
{
    public class IndexModel : PageModel
    {
        private readonly KSUWEBPMOCAPContext _context;

        public IndexModel(KSUWEBPMOCAPContext context)
        {
            _context = context;
        }

        public string ProjectNumSort { get; set; }
        public string StartDateSort { get; set; }
        public string ProjectTypeSort { get; set; }
        public string ProjectDepartmentSort { get; set; }
        public string ProjectDescriptionSort { get; set; }
        public string SponsorSort { get; set; }
        public string CurrentFilter { get; set; }
        public string CurrentSort { get; set; }


        //public IList<Project> Projects { get; set; }
        public PaginatedList<Project> Projects { get; set; }


        public async Task OnGetAsync(string sortOrder, string searchString, int? pageIndex, string CurrentFilter)

        {
            CurrentSort = sortOrder;
            ProjectNumSort = String.IsNullOrEmpty(sortOrder) ? "Project_Num" : "";
            StartDateSort = sortOrder == "Date" ? " date_desc" : "Date";
            ProjectTypeSort = sortOrder == "TypeSort" ? "TypeSort_desc" : "";
            SponsorSort = sortOrder == "Sponsor_Sort" ? "Sponsor_desc_Sort" : "";
            CurrentFilter = searchString;
            if (searchString != null)
            {
                pageIndex = 1;
            }
            else
            {
                searchString = CurrentFilter;
            }

            IQueryable<Project> projectsIQ = from s in _context.Project select s;
            if (!String.IsNullOrEmpty(searchString))
            {
                projectsIQ = projectsIQ.Where(s => s.Faculty_LastName.Contains(searchString)
                                       || s.Project_Num.Contains(searchString) || s.Proj_Type.Contains(searchString)
                                       || s.Project_Description.Contains(searchString) || s.Sponsor_Name.Contains(searchString)
                                       || s.Dept_Name.Contains(searchString));
            }


            switch (sortOrder)
            {
                case "Project_Num":
                    projectsIQ = projectsIQ.OrderByDescending(s => s.Project_Num);
                    break;
                case "Date":
                    projectsIQ = projectsIQ.OrderBy(s => s.StartDate);
                    break;
                case "date_desc":
                    projectsIQ = projectsIQ.OrderByDescending(s => s.StartDate);
                    break;
                case "TypeSort":
                    projectsIQ = projectsIQ.OrderBy(s => s.Proj_Type);
                    break;
                case "TypeSort_DESC":
                    projectsIQ = projectsIQ.OrderByDescending(s => s.Proj_Type);
                    break;

                default:
                    projectsIQ = projectsIQ.OrderBy(s => s.Project_Num);
                    break;
            }
            int pageSize = 5;
            Projects = await PaginatedList<Project>.CreateAsync(
                projectsIQ.AsNoTracking(), pageIndex ?? 1, pageSize);
            //Projects = await projectsIQ.AsNoTracking().ToListAsync();
        }
    }
}



