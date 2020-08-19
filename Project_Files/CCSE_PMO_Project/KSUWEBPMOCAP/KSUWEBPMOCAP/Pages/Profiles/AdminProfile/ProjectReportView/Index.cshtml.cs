using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using KSUWEBPMOCAP.Data;

namespace KSUWEBPMOCAP.Pages.ProjectReport
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
        public string ProjectDescription { get; set; }
        public string SponsorSort { get; set; }
        public string StudentLastName{ get; set; }
        public string FacultyLastName { get; set; }
        public string CurrentFilter { get; set; }
        public string CurrentSort { get; set; }


        //public IList<Project> Projects { get; set; }
        public PaginatedList<Project> Projectss { get; set; }
        public List<Project> Projects { get; private set; }

        public async Task OnGetAsync(string sortOrder, string searchString, int? pageIndex, string CurrentFilter)

        {
            CurrentSort = sortOrder;

            ProjectNumSort = String.IsNullOrEmpty(sortOrder) ? "Project_Num" : "";
            StartDateSort = sortOrder == "Date" ? " Date_Desc" : "Date";
            ProjectTypeSort = sortOrder == "TypeSort" ? "TypeSort_DESC" : "";
            ProjectDescription = sortOrder == "Description_Sort" ? " DeScription_Desc_Sort" : "";
            SponsorSort = sortOrder == "SponsorSort" ? " Sponsor_Desc_Sort" : "";
            StudentLastName = sortOrder == "StudentLastName_Asc_Sort" ? " StudentLastName_Desc_Sort" : "";
            FacultyLastName = sortOrder == "FacultyLastName" ? " FacultyLastName_Desc_Sort" : "";
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
                projectsIQ = projectsIQ.Where(s => s.Sponsor_Name.Contains(searchString)
                                       || s.Project_Num.Contains(searchString) || s.Proj_Type.Contains(searchString));
            }


            switch (sortOrder)
            {
                case "Project_Num":
                    projectsIQ = projectsIQ.OrderByDescending(s => s.Project_Num);
                    break;
                case "Date":
                    projectsIQ = projectsIQ.OrderBy(s => s.StartDate);
                    break;
                case "Date_Desc":
                    projectsIQ = projectsIQ.OrderByDescending(s => s.StartDate);
                    break;
                case "TypeSort":
                    projectsIQ = projectsIQ.OrderBy(s => s.Proj_Type);
                    break;
                case " TypeSort_DESC":
                    projectsIQ = projectsIQ.OrderByDescending(s => s.Proj_Type);
                    break;
                case "Desciption_Sort":
                    projectsIQ = projectsIQ.OrderBy(s => s.Project_Description);
                    break;
                case " Description_Desc_Sort":
                    projectsIQ = projectsIQ.OrderByDescending(s => s.Project_Description);
                    break;
                
                case "FacultyLastName_Desc_Sort ":                
                    projectsIQ = projectsIQ.OrderByDescending(s => s.Faculty_LastName);
                    break;
                case "SponsorSort":
                    projectsIQ = projectsIQ.OrderBy(s => s.Sponsor_Name);
                    break;

                case "Sponsor_Desc_Sort":
                    projectsIQ = projectsIQ.OrderByDescending(s => s.Sponsor_Name);
                    break;
                default:
                    projectsIQ = projectsIQ.OrderBy(s => s.Project_Num);
                    break;
            }

            Projects = await projectsIQ.AsNoTracking().ToListAsync();
        }
    }
}




