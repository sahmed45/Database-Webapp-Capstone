using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using KSUWEBPMOCAP.Data;

namespace KSUWEBPMOCAP.Pages.Profiles.AdminProfile.Departments
{
    public class IndexModel : PageModel
    {
        private readonly KSUWEBPMOCAPContext _context;

        public IndexModel(KSUWEBPMOCAPContext context)
        {
            _context = context;
        }

        public int DeptNumSort { get; set; }
        public string DeptNameSort { get; set; }
        public string FacultyLastNAme { get; set; }
        public string CurrentFilter { get; set; }
        public string CurrentSort { get; set; }



        public PaginatedList<Department> Departments { get; set; }
        //public List<Department> Department { get; private set; }

        public async Task OnGetAsync(string sortOrder, string searchString, int? pageIndex, string CurrentFilter)

        {
            CurrentSort = sortOrder;

            DeptNameSort = String.IsNullOrEmpty(sortOrder) ? "DeptName" : "";
            FacultyLastNAme = sortOrder == "FacultyLadtName" ? "FacultyLastName_desc" : "";

            CurrentFilter = searchString;
            if (searchString != null)
            {
                pageIndex = 1;
            }
            else
            {
                searchString = CurrentFilter;
            }

            IQueryable<Department> departmentsIQ = from s in _context.Department select s;
            if (!String.IsNullOrEmpty(searchString))
            {
                departmentsIQ = departmentsIQ.Where(s => s.Dept_Name.Contains(searchString)
                                       || s.Faculty_LastName.Contains(searchString));
            }


            switch (sortOrder)
            {
                case "DeptName":
                    departmentsIQ = departmentsIQ.OrderByDescending(s => s.Dept_Name);
                    break;
                case "FacultyName":
                    departmentsIQ = departmentsIQ.OrderBy(s => s.Faculty_LastName);
                    break;

                case "FacultyLastName_desc":
                    departmentsIQ = departmentsIQ.OrderByDescending(s => s.Faculty_LastName);
                    break;

                default:
                    departmentsIQ = departmentsIQ.OrderBy(s => s.Dept_Name);
                    break;
            }

            //Department = await departmentsIQ.AsNoTracking().ToListAsync();
            int pageSize = 5;
            Departments = await PaginatedList<Department>.CreateAsync(
                departmentsIQ.AsNoTracking(), pageIndex ?? 1, pageSize);
        }
    }
}
