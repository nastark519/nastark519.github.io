using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HW5.DAL;
using HW5.Models;

namespace HW5.Controllers
{
    public class HomeController : Controller
    {
        //make the database to be used.
        private DMVContext db = new DMVContext();

        public ActionResult Index()
        {
            return View();
        }


        public ActionResult Page1()
        {
            return View();
        }

        public ActionResult Page2()
        {
            return View();
        }
    }
}