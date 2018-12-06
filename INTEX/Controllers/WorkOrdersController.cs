using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using INTEX.DAL;
using INTEX.Models;

namespace INTEX.Controllers
{
    public class WorkOrdersController : Controller
    {
        private IntexContext db = new IntexContext();

        // GET: WorkOrders
        public ActionResult Index()
        {
            var workOrder = db.WorkOrder.Include(w => w.Compound).Include(w => w.Order).Include(w => w.Status);
            return View(workOrder.ToList());
        }

        // GET: WorkOrders/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            WorkOrder workOrder = db.WorkOrder.Find(id);
            if (workOrder == null)
            {
                return HttpNotFound();
            }
            return View(workOrder);
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

        // GET: WorkOrders/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            WorkOrder workOrder = db.WorkOrder.Find(id);
            if (workOrder == null)
            {
                return HttpNotFound();
            }
            ViewBag.LTNumber = new SelectList(db.Compound, "LTNumber", "CompoundName", workOrder.LTNumber);
            ViewBag.OrderID = new SelectList(db.Order, "OrderID", "OrderID", workOrder.OrderID);
            ViewBag.StatusID = new SelectList(db.Status, "StatusID", "StatusDescription", workOrder.StatusID);
            return View(workOrder);
        }

        // POST: WorkOrders/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "WorkOrderID,DueDate,SummaryReport,OrderID,StatusID,LTNumber")] WorkOrder workOrder)
        {
            if (ModelState.IsValid)
            {
                db.Entry(workOrder).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.LTNumber = new SelectList(db.Compound, "LTNumber", "CompoundName", workOrder.LTNumber);
            ViewBag.OrderID = new SelectList(db.Order, "OrderID", "OrderID", workOrder.OrderID);
            ViewBag.StatusID = new SelectList(db.Status, "StatusID", "StatusDescription", workOrder.StatusID);
            return View(workOrder);
        }

        // GET: WorkOrders/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            WorkOrder workOrder = db.WorkOrder.Find(id);
            if (workOrder == null)
            {
                return HttpNotFound();
            }
            return View(workOrder);
        }

        // POST: WorkOrders/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            WorkOrder workOrder = db.WorkOrder.Find(id);
            db.WorkOrder.Remove(workOrder);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
