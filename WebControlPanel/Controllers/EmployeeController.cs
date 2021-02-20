using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using dz;

namespace WebControlPanel.Controllers
{
    public class EmployeeController : Controller
    {
        const string stateFileName = @"d:\company.xml";
        private Company company = Company.Load(stateFileName);

        
        // GET: Employee
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
