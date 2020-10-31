﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BusinessLayer;
using System.Configuration;

namespace MVCDemo.Controllers
{
    public class EmployeeListController : Controller
    {
        // GET: EmployeeList
        public ActionResult Index()
        {
            EmployeeBusinessLayer employeeBusinessLayer = new EmployeeBusinessLayer();
            List<Employee> employees =  employeeBusinessLayer.Employees.ToList();
            return View(employees);
        }

        [HttpGet ]
        public ActionResult Create()
        {
           
            return View();
        }
    }
}