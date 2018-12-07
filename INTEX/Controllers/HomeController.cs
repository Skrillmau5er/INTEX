//Authors: Alec Ostheimer, Ben Walbrecht, Zach McQuiston, Cash Allred

//Description: This project helps Northwest Labs with keeps work orders up to date and trackable for customers. 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace INTEX.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Northwest info";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(string username, string password)
        {
            if (username == "seattle" && password == "customersupport")
            {
                return RedirectToAction("Index", "Seattle");
            }
            else if (username == "singapore" && password == "labemployee")
            {
                return RedirectToAction("Index", "Singapore");
            }
            else if (username == "customer" && password == "password")
            {
                return RedirectToAction("Index","Customer");
            }
            else if (username == "owenwilson" && password == "wowfactor")
            {
                return RedirectToAction("OwenWilson", "Home");
            }
            else
            {
                ViewBag.LoginError = "Incorrect Login Information. Please Try Again.";
                return View();
            }
        }

        public ActionResult OwenWilson()
        {
            return View();
        }
    }
}