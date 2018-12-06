using INTEX.DAL;
using INTEX.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
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

        public ActionResult OrderDetails(int? id)
        {
            /*if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }*/
            Orders order = db.Order.Find(id);
            /*if (WorkOrder == null)
            {
                return HttpNotFound();
            }*/
            return View(order);
        }


        public ActionResult OrderHistory()
        {

            return View(db.Order.ToList());
        }
        public ActionResult TestResults()
        {
            return View();
        }
    }
}