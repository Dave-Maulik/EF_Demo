using EF_Demo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EF_Demo.Controllers
{
    public class AddController : Controller
    {
        EmployeeDataOps Db;
        public AddController()
        {
            Db = new EmployeeDataOps();
        }
        [HttpGet]
        public ActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Add(Employee employee)
        {
            Db.AddEmp(employee);
            return RedirectToAction("Index","Home");
        }
    }
}