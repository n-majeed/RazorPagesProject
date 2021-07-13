using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPagesProject.Data;
using RazorPagesProject.Models;

namespace RazorPagesProject.Pages.Employees
{
    public class DetailsModel : PageModel
    {
        private readonly RazorPagesProject.Data.RazorPagesProjectContext _context;

        public DetailsModel(RazorPagesProject.Data.RazorPagesProjectContext context)
        {
            _context = context;
        }

        public EmployeeModel EmployeeModel { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            EmployeeModel = await _context.EmployeeModel.FirstOrDefaultAsync(m => m.Id == id);

            if (EmployeeModel == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
