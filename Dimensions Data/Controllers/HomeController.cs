using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Dimensions_Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Http;

namespace Dimensions_Data.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly DimensionsDataProjectContext db = new DimensionsDataProjectContext();
        LoginInformation log = new LoginInformation();
        public const string SessionName = "";

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }



        public IActionResult Index()
        {
            return View();
            log.loggingSuccess = false;
        }


        [HttpPost]
        public IActionResult Login(String email,String password)
        {
            var user = db.LoginInformations.Where(s => s.Email.Equals(email) && s.Password.Equals(password));
            if (user.Count() == 1)
            {
                HttpContext.Session.SetString(SessionName, email);
                return RedirectToAction("Dashboard", "Dashboard");
            }
           

            return View("Index");
        }

        public IActionResult CreateAccount()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateAccount(LoginInformation created)
        {
            if (ModelState.IsValid) {
                db.LoginInformations.Add(created);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(created);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
