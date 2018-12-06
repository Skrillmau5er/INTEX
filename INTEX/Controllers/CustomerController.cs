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
            ViewBag.ID = id;
            Orders order = db.Order.Find(id);
            ViewBag.Order = order;
            /*if (WorkOrder == null)
            {
                return HttpNotFound();
            }*/
            return View(db.WorkOrder.ToList());
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