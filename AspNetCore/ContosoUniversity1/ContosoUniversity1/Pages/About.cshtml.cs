using ContosoUniversity1.Models;
using ContosoUniversity1.Models.SchoolViewModels;
using ContosoUniversity1.Data;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContosoUniversity1.Pages
{
    public class AboutModel : PageModel
    {
        private readonly SchoolContext _schoolContext;
        public AboutModel(SchoolContext schoolContext)
        {
            _schoolContext = schoolContext;
        }

        public IList<EnrollmentDateGroup> Students { get; set; }

        public async Task OnGetAsync()
        {
            IQueryable<EnrollmentDateGroup> data =
                from student in _schoolContext.Students
                group student by student.EnrollmentData into dateGroup
                select new EnrollmentDateGroup()
                {
                    EnrollmentDate = dateGroup.Key,
                    StudentCount = dateGroup.Count()
                };

            Students = await data.AsNoTracking().ToListAsync();
        }
    }
}
