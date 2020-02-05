using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EF_Demo.Models
{
    public class Employee
    {
        [Key]
        public int EmpId { get; set; }
        [Required]
        public string EmpName { get; set; }
        [Required]
        public int EmpAge { get; set; }
        [Required]
        public Departments EmpDepartment { get; set; }
    }
}