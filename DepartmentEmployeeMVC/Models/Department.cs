using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DepartmentEmployeeMVC.Models
{
    public class Department
    {
        public int Id { get; set; }

        [Display(Name = "Department Name")]
        [Required]
        [MaxLength(15, ErrorMessage = "Department Name must be less then 16 characters")]
        public string Name { get; set; }
        public List<Employee> Employees { get; set; } = new List<Employee>();
    }
}
