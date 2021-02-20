using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using dz;

namespace WebPanel.Controllers
{
    public class EmployeesController : Controller
    {
        const string stateFileName = @"d:\company.xml";
        private Company company = Company.Load(stateFileName);

        // GET: Employees
        public ActionResult Index()
        {
            var employees = new List<Employee> { };
            if (company.Subdivisions != null)
            {
                foreach (Subdivision sub in company.Subdivisions)
                {

                    foreach (Employee emp in sub.Employees)
                    {
                        employees.Add(emp);
                    }


                }
                ViewBag.Employees = employees;
            }
            return View();
        }
    }
}