using INTEX.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using INTEX.Models;

namespace INTEX.Controllers
{
    public class SeattleController : Controller
    {
        private IntexContext db = new IntexContext();
        // GET: Seattle
        public ActionResult Index()
        {
            return View();
        }

        // GET: WorkOrders/Create
        public ActionResult Create()
        {
            ViewBag.LTNumber = new SelectList(db.Compound, "LTNumber", "CompoundName");
            ViewBag.OrderID = new SelectList(db.Order, "OrderID", "OrderID");
            ViewBag.StatusID = new SelectList(db.Status, "StatusID", "StatusDescription");
            return View();
        }

        // POST: WorkOrders/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "WorkOrderID,DueDate,SummaryReport,OrderID,StatusID,LTNumber")] WorkOrder workOrder)
        {
            if (ModelState.IsValid)
            {
                db.WorkOrder.Add(workOrder);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.LTNumber = new SelectList(db.Compound, "LTNumber", "CompoundName", workOrder.LTNumber);
            ViewBag.OrderID = new SelectList(db.Order, "OrderID", "OrderID", workOrder.OrderID);
            ViewBag.StatusID = new SelectList(db.Status, "StatusID", "StatusDescription", workOrder.StatusID);
            return View(workOrder);
        }
    }
}