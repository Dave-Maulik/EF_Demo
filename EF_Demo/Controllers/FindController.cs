using EF_Demo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EF_Demo.Controllers
{
    public class FindController : Controller
    {
        EmployeeDataOps Db;
        public FindController()
        {
            Db = new EmployeeDataOps();
        }
        // GET: Find
        public ActionResult Search()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Search(Employee employee)
        {
            if (ModelState.IsValid)
            {
                var result = Db.GetEmp(employee);
                return RedirectToAction("show", "Show",result);
               
            }
            return View();
        }
    }
}