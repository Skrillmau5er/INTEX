using INTEX.DAL;
using INTEX.Models;
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

        public ActionResult Quote()
        {
            return View();
        }

        public ActionResult CurrentOrders()
        {
            return View(db.Order.ToList());
        }

        [HttpGet]
        public ActionResult OrderDetails(int ID)
        {
            return View();
        }


        public ActionResult OrderHistory()
        {

            return View();
        }
    }
}