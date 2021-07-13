using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RazorPagesProject.Models
{
    public class EmployeeModel
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string Designation { get; set;}

        [DataType(DataType.Date)]
        public DateTime JoinigDate { get; set; }
      
        public int Salary { get; set; }

    }
}
