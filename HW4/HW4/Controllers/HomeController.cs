﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HW4.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        //GET: Page1
        public ActionResult Page1()
        {
            return View();
        }

        //GET: Page2
        public ActionResult Page2()
        {
            return View();
        }

        //GET: Page3
        public ActionResult Page3()
        {
            return View();
        }
    }
}