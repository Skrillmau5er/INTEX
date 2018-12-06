﻿using INTEX.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace INTEX.Controllers
{
    public class SingaporeController : Controller
    {
        private IntexContext db = new IntexContext();
        // GET: Singapore
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult WorkOrders()
        {
            return View(db.WorkOrders.ToList());
        }
        public ActionResult QuoteRequests()
        {
            return View(db.Order.ToList());
        }
    }
}