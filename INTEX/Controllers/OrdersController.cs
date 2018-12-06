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
    public class OrdersController : Controller
    {
        private IntexContext db = new IntexContext();

        // GET: Orders
        public ActionResult Index()
        {
            var order = db.Order.Include(o => o.Customer).Include(o => o.Employee).Include(o => o.Invoice);
            return View(order.ToList());
        }

        // GET: Orders/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Orders orders = db.Order.Find(id);
            if (orders == null)
            {
                return HttpNotFound();
            }
            return View(orders);
        }

        // GET: Orders/Create
        public ActionResult Create()
        {
            ViewBag.CustomerID = new SelectList(db.Customer, "CustomerID", "CustFirstName");
            ViewBag.EmployeeID = new SelectList(db.Employee, "EmployeeID", "EmpFirstName");
            ViewBag.InvoiceID = new SelectList(db.Invoice, "InvoiceID", "InvoiceID");
            return View();
        }

        // POST: Orders/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "OrderID,OrderDate,QuotedPrice,ActualPrice,CustomerID,EmployeeID,InvoiceID")] Orders orders)
        {
            if (ModelState.IsValid)
            {
                db.Order.Add(orders);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.CustomerID = new SelectList(db.Customer, "CustomerID", "CustFirstName", orders.CustomerID);
            ViewBag.EmployeeID = new SelectList(db.Employee, "EmployeeID", "EmpFirstName", orders.EmployeeID);
            ViewBag.InvoiceID = new SelectList(db.Invoice, "InvoiceID", "InvoiceID", orders.InvoiceID);
            return View(orders);
        }

        // GET: Orders/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Orders orders = db.Order.Find(id);
            if (orders == null)
            {
                return HttpNotFound();
            }
            ViewBag.CustomerID = new SelectList(db.Customer, "CustomerID", "CustFirstName", orders.CustomerID);
            ViewBag.EmployeeID = new SelectList(db.Employee, "EmployeeID", "EmpFirstName", orders.EmployeeID);
            ViewBag.InvoiceID = new SelectList(db.Invoice, "InvoiceID", "InvoiceID", orders.InvoiceID);
            return View(orders);
        }

        // POST: Orders/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "OrderID,OrderDate,QuotedPrice,ActualPrice,CustomerID,EmployeeID,InvoiceID,OrderDetails")] Orders orders)
        {
            if (ModelState.IsValid)
            {
                db.Entry(orders).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.CustomerID = new SelectList(db.Customer, "CustomerID", "CustFirstName", orders.CustomerID);
            ViewBag.EmployeeID = new SelectList(db.Employee, "EmployeeID", "EmpFirstName", orders.EmployeeID);
            ViewBag.InvoiceID = new SelectList(db.Invoice, "InvoiceID", "InvoiceID", orders.InvoiceID);
            return View(orders);
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
