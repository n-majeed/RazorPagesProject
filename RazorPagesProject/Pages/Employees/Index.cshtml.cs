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
    public class IndexModel : PageModel
    {
        private readonly RazorPagesProject.Data.RazorPagesProjectContext _context;

        public IndexModel(RazorPagesProject.Data.RazorPagesProjectContext context)
        {
            _context = context;
        }

        public IList<EmployeeModel> EmployeeModel { get;set; }

        public async Task OnGetAsync()
        {
            EmployeeModel = await _context.EmployeeModel.ToListAsync();
        }
    }
}
