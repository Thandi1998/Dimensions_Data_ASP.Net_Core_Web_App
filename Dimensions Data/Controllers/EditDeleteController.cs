using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dimensions_Data.Models;
using Microsoft.AspNetCore.Mvc;

namespace Dimensions_Data.Controllers
{
    public class EditDeleteController : Controller
    {
        private readonly DimensionsDataProjectContext db = new DimensionsDataProjectContext();
        
        public IActionResult EditEmployeePerfomance(int id)
        {
            if (id == null) {
                return NotFound();
            }

            var obj = db.PerfomanceAndRates.Find(id);
            if (obj == null)
            {
                return NotFound();
            }
            
            return View(obj);
        }

        [HttpPost]
        public IActionResult EditEmployeePerfomance(PerfomanceAndRate obj) {
            if (ModelState.IsValid) {
                db.PerfomanceAndRates.Update(obj);
                db.SaveChanges();
                return RedirectToAction("EditEmployeePerfomance");
            }
            return View(obj);
        }

        public IActionResult DeleteEmployeePerfomance(int id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var obj = db.PerfomanceAndRates.Find(id);
            if (obj == null)
            {
                return NotFound();
            }
            
            return View(obj);
        }

        [HttpPost]
        public IActionResult DeleteEmployeePerfomance(PerfomanceAndRate obj)
        {
            if (obj == null)
            {
                return NotFound();
            }
            db.PerfomanceAndRates.Remove(obj);
            db.SaveChanges();
            return RedirectToAction("employeePerfomance", "Dashboard");
        }

        public IActionResult AddEmployeePerfomance()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddPerfomance(PerfomanceAndRate userCreated)
        {
            if (ModelState.IsValid)
            {
                db.PerfomanceAndRates.Add(userCreated);
                db.SaveChanges();
                return RedirectToAction("employeePerfomance", "Dashboard");
            }

            return View();
        }


        public IActionResult EditEmployeeBasicInfo(int id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var obj = db.EmployeeBasicInfos.Find(id);
            if (obj == null)
            {
                return NotFound();
            }

            return View(obj);
        }

        [HttpPost]
        public IActionResult EditEmployeeBasicInfo(EmployeeBasicInfo obj)
        {
            if (ModelState.IsValid)
            {
                db.EmployeeBasicInfos.Update(obj);
                db.SaveChanges();
                return RedirectToAction("EditEmployeeBasicInfo");
            }
            return View(obj);
        }

        public IActionResult DeleteEmployeeBasicInfo(int id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var obj = db.EmployeeBasicInfos.Find(id);
            if (obj == null)
            {
                return NotFound();
            }

            return View(obj);
        }
        
        [HttpPost]
        public IActionResult DeleteEmployeeBasicInfo(EmployeeBasicInfo obj)
        {
            if (obj == null)
            {
                return NotFound();
            }
            db.EmployeeBasicInfos.Remove(obj);
            db.SaveChanges();
            return RedirectToAction("employeeBasicinfo", "Dashboard");
        }

        public IActionResult EditEmployeePersonalInfo(int id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var obj = db.EmployeePersonals.Find(id);
            if (obj == null)
            {
                return NotFound();
            }

            return View(obj);
        }

        public IActionResult AddEmployeeBasicInfo()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddEmployeeBasicInfo(EmployeeBasicInfo userCreated)
        {
            if (ModelState.IsValid)
            {
                db.EmployeeBasicInfos.Add(userCreated);
                db.SaveChanges();
                return RedirectToAction("employeeBasicinfo", "Dashboard");
            }

            return View();
        }

        [HttpPost]
        public IActionResult EditEmployeePersonalInfo(EmployeePersonal obj)
        {
            if (ModelState.IsValid)
            {
                db.EmployeePersonals.Update(obj);
                db.SaveChanges();
                return RedirectToAction("EditEmployeePersonalInfo");
            }
            return View(obj);
        }

        public IActionResult DeleteEmployeePersonalInfo(int id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var obj = db.EmployeePersonals.Find(id);
            if (obj == null)
            {
                return NotFound();
            }

            return View(obj);
        }

        [HttpPost]
        public IActionResult DeleteEmployeePersonalInfo(EmployeePersonal obj)
        {
            if (obj == null)
            {
                return NotFound();
            }
            
            db.EmployeePersonals.Remove(obj);

            db.SaveChanges();
            return RedirectToAction("employeePersonalinfor", "Dashboard");
        }

        public IActionResult AddEmployeePersonalInfo()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddEmployeePersonalInfo(EmployeePersonal userCreated)
        {
            if (ModelState.IsValid)
            {
                db.EmployeePersonals.Add(userCreated);
                db.SaveChanges();
                return RedirectToAction("employeePersonalinfor", "Dashboard");
            }

            return View();
        }

        /*public IActionResult Delete() {
            return View();
        }

        [HttpPost]
        public IActionResult DeletePost(int id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var objPersonal = db.EmployeePersonals.Find(id);
            var objWork = db.EmployeeWorkInfomations.Find(id);
            var objBasic = db.EmployeeBasicInfos.Find(id);
            var objDepartment = db.DepartmentsAndEducations.Find(id);
            var objPerfomance = db.PerfomanceAndRates.Find(id);

            if (objPersonal == null || objBasic == null ||objWork == null || objDepartment == null ||objPerfomance == null) {
                return NotFound();
            }

            db.EmployeeWorkInfomations.Remove(objWork);
            db.EmployeeBasicInfos.Remove(objBasic);
            db.EmployeePersonals.Remove(objPersonal);
            db.DepartmentsAndEducations.Remove(objDepartment);
            db.PerfomanceAndRates.Remove(objPerfomance);

            db.SaveChanges();
            return RedirectToAction("Dashboard","Dashboard");
        }*/

        public IActionResult EditEmployeeWorkInfo(int id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var obj = db.EmployeeWorkInfomations.Find(id);
            if (obj == null)
            {
                return NotFound();
            }

            return View(obj);
        }

        [HttpPost]
        public IActionResult EditEmployeeWorkInfo(EmployeeWorkInfomation obj)
        {
            if (ModelState.IsValid)
            {
                db.EmployeeWorkInfomations.Update(obj);
                db.SaveChanges();
                return RedirectToAction("EditEmployeeWorkInfo");
            }
            return View(obj);
        }

        public IActionResult DeleteEmployeeWorkInfo(int id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var obj = db.EmployeeWorkInfomations.Find(id);
            if (obj == null)
            {
                return NotFound();
            }

            return View(obj);
        }

        [HttpPost]
        public IActionResult DeleteEmployeeWorkInfo(EmployeeWorkInfomation obj)
        {
            if (obj == null)
            {
                return NotFound();
            }

            db.EmployeeWorkInfomations.Remove(obj);

            db.SaveChanges();
            return RedirectToAction("employeeWorkInfo", "Dashboard");
        }

        public IActionResult AddEmployeeWorkInfo()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddEmployeeWorkInfo(EmployeeWorkInfomation userCreated)
        {
            if (ModelState.IsValid)
            {
                db.EmployeeWorkInfomations.Add(userCreated);
                db.SaveChanges();
                return RedirectToAction("employeeWorkInfo", "Dashboard");
            }

            return View();
        }

        public IActionResult EditDepartmentsAndEducation(int id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var obj = db.DepartmentsAndEducations.Find(id);
            if (obj == null)
            {
                return NotFound();
            }

            return View(obj);
        }

        [HttpPost]
        public IActionResult EditDepartmentsAndEducation(DepartmentsAndEducation obj)
        {
            if (ModelState.IsValid)
            {
                db.DepartmentsAndEducations.Update(obj);
                db.SaveChanges();
                return RedirectToAction("EditDepartmentsAndEducation");
            }
            return View(obj);
        }

        public IActionResult DeleteDepartmentsAndEducation(int id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var obj = db.DepartmentsAndEducations.Find(id);
            if (obj == null)
            {
                return NotFound();
            }

            return View(obj);
        }

        [HttpPost]
        public IActionResult DeleteDepartmentsAndEducation(DepartmentsAndEducation obj)
        {
            if (obj == null)
            {
                return NotFound();
            }

            db.DepartmentsAndEducations.Remove(obj);

            db.SaveChanges();
            return RedirectToAction("employeeDepartments", "Dashboard");
        }

        public IActionResult AddDepartmentsAndEducation()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddDepartmentsAndEducation(DepartmentsAndEducation userCreated)
        {
            if (ModelState.IsValid)
            {
                db.DepartmentsAndEducations.Add(userCreated);
                db.SaveChanges();
                return RedirectToAction("employeeDepartments","Dashboard");
            }

            return View();
        }
    }
}
