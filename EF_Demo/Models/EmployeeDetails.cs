using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EF_Demo.Models
{
    public class EmployeeDetails
    {
        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public int EmpAge { get; set; }
        public Departments EmpDepartment { get; set; }
    }
}