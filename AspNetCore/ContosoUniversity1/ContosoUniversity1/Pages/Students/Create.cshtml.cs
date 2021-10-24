﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using ContosoUniversity1.Data;
using ContosoUniversity1.Models;

namespace ContosoUniversity1.Pages.Students
{
    public class CreateModel : PageModel
    {
        private readonly ContosoUniversity1.Data.SchoolContext _context;

        public CreateModel(ContosoUniversity1.Data.SchoolContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Student Student { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            var emptyStudent = new Student();

            if(await TryUpdateModelAsync<Student>(
                emptyStudent, 
                "student",
                s => s.FirstMidName, s => s.LastName, s => s.EnrollmentData))
            {
                _context.Students.Add(emptyStudent);
                await _context.SaveChangesAsync();
                return RedirectToPage("./Index");
            }
            return Page();
        }
    }
}
