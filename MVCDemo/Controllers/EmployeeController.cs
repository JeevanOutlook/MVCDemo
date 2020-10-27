using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCDemo.Models;

namespace MVCDemo.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Details()
        {
            Employee employee = new Employee()
            {
                EmployeeID = 100,
                Name = "Jeevan",
                Gender = "Male",
                City = "Delhi",
                Salary = 10000,
                Address = "Pune"
            };

            return View(employee );
        }
    }
}