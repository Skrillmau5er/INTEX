using INTEX.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace INTEX.Controllers
{
    public class CustomerController : Controller
    {
        private IntexContext db = new IntexContext();
        // GET: Customer
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult OrderStatus()
        {
            return View();
        }
    }
}