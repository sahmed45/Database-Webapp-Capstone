using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using KSUWEBPMOCAP.Data;

namespace KSUWEBPMOCAP.Pages.Profiles.AdminProfile.Faculties
{
    public class IndexModel : PageModel
    {
        private readonly KSUWEBPMOCAPContext _context;

        public IndexModel(KSUWEBPMOCAPContext context)
        {
            _context = context;
        }

        public string DeptSort { get; set; }
        public string LastNameSort { get; set; }
        public string FirstNameSort { get; set; }
        public string CurrentFilter { get; set; }
        public string CurrentSort { get; set; }


        //public IList<Project> Projects { get; set; }
        public PaginatedList<Faculty> Faculty { get; set; }
        public List<Faculty> Faculties { get; private set; }

        public async Task OnGetAsync(string sortOrder, string searchString, int? pageIndex, string CurrentFilter)

        {
            CurrentSort = sortOrder;

            LastNameSort = String.IsNullOrEmpty(sortOrder) ? "LastName" : string.Empty;
            DeptSort = sortOrder == "DeptName" ? "DeptName_desc" : " ";
            FirstNameSort = sortOrder == "FirstName" ? "FirstName_desc" : " ";
            CurrentFilter = searchString;
            if (searchString != null)
            {
                pageIndex = 1;
            }
            else
            {
                searchString = CurrentFilter;
            }

            IQueryable<Faculty> FacultiesIQ = from s in _context.Faculty select s;
            if (!String.IsNullOrEmpty(searchString))
            {
                FacultiesIQ = FacultiesIQ.Where(s => s.Faculty_LastName.Contains(searchString)
                                       || s.Faculty_FirstName.Contains(searchString) || s.Dept_Name.Contains(searchString));
            }


            switch (sortOrder)
            {
                case "lastName_desc":
                    FacultiesIQ = FacultiesIQ.OrderByDescending(s => s.Faculty_LastName);
                    break;
                    case "FirstName":
                    FacultiesIQ = FacultiesIQ.OrderBy(s => s.Faculty_FirstName);
                    break;
                case " FirstName_desc":
                    FacultiesIQ = FacultiesIQ.OrderByDescending(s => s.Faculty_FirstName);
                    break;
                case "DeptSort":
                    FacultiesIQ = FacultiesIQ.OrderBy(s => s.Dept_Name);
                    break;
                case "DeptSort_desc":
                    FacultiesIQ = FacultiesIQ.OrderByDescending(s => s.Dept_Name);
                    break;

                default:
                    FacultiesIQ = FacultiesIQ.OrderBy(s => s.Faculty_LastName);
                    break;
            }

            Faculties = await FacultiesIQ.AsNoTracking().ToListAsync();
            int pageSize = 5;
            Faculty = await PaginatedList<Faculty>.CreateAsync(
                FacultiesIQ.AsNoTracking(), pageIndex ?? 1, pageSize);
        }
    }
}

