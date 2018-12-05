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

        public ActionResult Login(string username, string password)
        {
            if (username == "singapore" && password == "labemployee")
            {
                return RedirectToAction("Index");
            }
            else if (username == "seattle" && password == "customersupport")
            {
                return RedirectToAction("Index");
            }
            else if (username == "customer" && password == "password")
            {
                return RedirectToAction("Index");
            }
            else
            {
                return View();
            }
        }
    }
}