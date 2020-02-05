using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EF_Demo.Models
{
    public class EmployeeDataOps
    {
        EmployeeDbContext Db;

        public EmployeeDataOps()
        {
            Db = new EmployeeDbContext();
        }

        public void AddEmp(Employee employee)
        {
            //var Age = (int)employee.EmpAge;
            //employee.EmpAge = Age;
            Db.TEmployees.Add(employee);
            Db.SaveChanges();
        }


        public List<Employee> GetEmp(Employee employee)
        {
            var result = Db.TEmployees.Where(b => b.EmpDepartment == employee.EmpDepartment &&  b.EmpAge <= employee.EmpAge ).ToList();
            return result;
        }
    }
}