using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using KSUWEBPMOCAP.Data;

namespace KSUWEBPMOCAP.Pages.Profiles.AdminProfile.Assignments
{
    public class IndexModel : PageModel
    {
        private readonly KSUWEBPMOCAPContext _context;

        public IndexModel(KSUWEBPMOCAPContext context)
        {
            _context = context;
        }

        public string ProjectNumSort { get; set; }
        public string FacultyLastNameSort { get; set; }
        public string StudentLastNameSort { get; set; }
        public string CurrentFilter { get; set; }
        public string CurrentSort { get; set; }


        public IList<Assignment> Assignment { get; set; }
        public PaginatedList<Assignment> Assignments { get; set; }

        public async Task OnGetAsync(string sortOrder, string searchString, int? pageIndex, string CurrentFilter)

        {
            CurrentSort = sortOrder;

            ProjectNumSort = String.IsNullOrEmpty(sortOrder) ? "ProjectNum" : "";
            FacultyLastNameSort = sortOrder == "FacultyLastName" ? "FacultyLastName_desc" : "";
            StudentLastNameSort = sortOrder == "StudentLastName" ? "StudentLastName_desc" : "";
            CurrentFilter = searchString;
            if (searchString != null)
            {
                pageIndex = 1;
            }
            else
            {
                searchString = CurrentFilter;
            }

            IQueryable<Assignment> AssignmentsIQ = from s in _context.Assignment select s;
            if (!String.IsNullOrEmpty(searchString))
            {
                AssignmentsIQ = AssignmentsIQ.Where(s => s.Project_Num.Contains(searchString)
                                       || s.Faculty_LastName.Contains(searchString) || s.Student_LastName.Contains(searchString));
            }


            switch (sortOrder)

            {
                case "ProjectNum":
                    AssignmentsIQ = AssignmentsIQ.OrderByDescending(s => s.Project_Num);
                    break;

                case "FacultyLastName_desc":
                    AssignmentsIQ = AssignmentsIQ.OrderByDescending(s => s.Faculty_LastName);
                    break;
                case "Faculty_LastName":
                    AssignmentsIQ = AssignmentsIQ.OrderBy(s => s.Faculty_LastName);
                    break;

                case "StudentLastName":
                    AssignmentsIQ = AssignmentsIQ.OrderByDescending(s => s.Student_LastName);
                    break;
                case "StudentLastName_desc":
                    AssignmentsIQ = AssignmentsIQ.OrderBy(s => s.Student_LastName);
                    break;
                default:
                    AssignmentsIQ = AssignmentsIQ.OrderBy(s => s.Project_Num);
                    break;
            }

            Assignment = await AssignmentsIQ.AsNoTracking().ToListAsync();
            int pageSize = 5;
            Assignments = await PaginatedList<Assignment>.CreateAsync(
                AssignmentsIQ.AsNoTracking(), pageIndex ?? 1, pageSize);
        }
    }
}

