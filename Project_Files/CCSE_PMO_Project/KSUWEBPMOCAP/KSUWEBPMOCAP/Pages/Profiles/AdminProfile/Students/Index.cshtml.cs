using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using KSUWEBPMOCAP.Data;

namespace KSUWEBPMOCAP.Pages.Profiles.AdminProfile.Students
{
    public class IndexModel : PageModel
    {
        private readonly KSUWEBPMOCAPContext _context;

        public IndexModel(KSUWEBPMOCAPContext context)
        {
            _context = context;
        }
        public string LastNameSort { get; set; }
        public string FirstNameSort { get; set; }
        public string CurrentFilter { get; set; }
        public string CurrentSort { get; set; }


       
        public PaginatedList<Student> Students { get; set; }

        public async Task OnGetAsync(string sortOrder, string searchString, int? pageIndex, string CurrentFilter)

        {
            CurrentSort = sortOrder;

            LastNameSort = String.IsNullOrEmpty(sortOrder) ? "LastName" : "";
            FirstNameSort = sortOrder == "FirstName" ? "FirstName_desc" : "";
            CurrentFilter = searchString;
            if (searchString != null)
            {
                pageIndex = 1;
            }
            else
            {
                searchString = CurrentFilter;
            }

            IQueryable<Student> StudentsIQ = from s in _context.Student select s;
            if (!String.IsNullOrEmpty(searchString))
            {
                StudentsIQ = StudentsIQ.Where(s => s.Student_LastName.Contains(searchString)
                                       || s.Student_FirstdName.Contains(searchString));
            }


            switch (sortOrder)
            {
                case "lastName_desc":
                    StudentsIQ = StudentsIQ.OrderByDescending(s => s.Student_LastName);
                    break;
                case "LastName":
                    StudentsIQ = StudentsIQ.OrderBy(s => s.Student_LastName);
                    break;

                case "FirstName":
                    StudentsIQ = StudentsIQ.OrderBy(s => s.Student_FirstdName);
                    break;

                default:
                    StudentsIQ = StudentsIQ.OrderBy(s => s.Student_LastName);
                    break;
            }

            // Students = await StudentsIQ.AsNoTracking().ToListAsync();
            int pageSize = 5;
            Students = await PaginatedList<Student>.CreateAsync(
                StudentsIQ.AsNoTracking(), pageIndex ?? 1, pageSize);
        }
    }
}
