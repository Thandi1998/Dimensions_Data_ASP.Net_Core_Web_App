using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Dimensions_Data.Models;

namespace Dimensions_Data.Controllers
{
    public class DashboardController : Controller
    {
        private readonly DimensionsDataProjectContext db = new DimensionsDataProjectContext();
        public IActionResult Dashboard()
        {
            
            return View();
        }

        public IActionResult employeePerfomance()
        {
            IEnumerable<PerfomanceAndRate> list = db.PerfomanceAndRates;
            return View(list);
        }

        public IActionResult employeePersonalinfor()
        {
            IEnumerable<EmployeePersonal> list = db.EmployeePersonals;
            return View(list);
        }

        public IActionResult employeeBasicinfo()
        {
            IEnumerable<EmployeeBasicInfo> list = db.EmployeeBasicInfos;
            return View(list);
        }

        public IActionResult employeeWorkInfo()
        {
            IEnumerable<EmployeeWorkInfomation> list = db.EmployeeWorkInfomations;
            return View(list);
        }

        public IActionResult employeeDepartments()
        {
            IEnumerable<DepartmentsAndEducation> list = db.DepartmentsAndEducations;
            return View(list);
        }

        

    }
}
