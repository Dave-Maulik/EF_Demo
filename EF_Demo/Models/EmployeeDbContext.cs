using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace EF_Demo.Models
{
    public class EmployeeDbContext : DbContext
    { 
        public DbSet<Employee> TEmployees { get; set; }
    }
}