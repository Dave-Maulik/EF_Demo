﻿using EF_Demo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EF_Demo.Controllers
{
    public class ShowController : Controller
    {
        
        // GET: Show
        public ActionResult Index()
        {
            List<Employee> emplist = (List<Employee>)TempData["Emps"];
            return View(emplist);
        }
    }
}