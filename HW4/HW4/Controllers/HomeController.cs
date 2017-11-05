using System;
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
        [HttpGet]
        public ActionResult Page1()
        {
            string temp = Request.QueryString["tempet"];
            if(!double.TryParse(temp, out double tempD))
            {
                ViewBag.Message = "Please enter a measurement and a temperature to start";
                return View();
            }
            
            string mSyst = Request.QueryString["sysM"];
            string answer = "here";
            ViewBag.RequestMethod = "GET";

            if(mSyst == null || mSyst == "")
            {
                ViewBag.Message = "Please enter a measurement to start" + tempD;
                return View();
            }

            //if(mSyst.ToLower == "fahrenheit" || mSyst.ToLower == "f")
            //{
            //answer = "here";
            //}

            ViewBag.Message = answer;
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