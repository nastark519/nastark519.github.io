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
            string answer = "Please enter a measurement and a temperature to start";
            string temp = Request.QueryString["tempet"];
            /*tests to see if temp is valid. If it is it initializes 
             * it an sets in in tempD => temperature as a double. If not valid
             * return an message to the user.*/
            if (!double.TryParse(temp, out double tempD))
            {
                ViewBag.Message = answer;
                return View();
            }
            //mSyst is what messurement system they have to work with.
            string mSyst = Request.QueryString["sysM"];
            //ViewBag.RequestMethod = "GET";
            double a, b;

            if (mSyst == null || mSyst == "")
            {
                ViewBag.Message = "Please enter a measurement to start" + tempD;
                return View();
            }

            if (mSyst.ToLower() == "fahrenheit" || mSyst.ToLower() == "f")
            {
                a = (tempD - 32) * 5 / 9;
                b = (tempD + 459.67) * 5 / 9;
                answer = "To Celsius: " + a + " To Kelvin: " + b;
            }
            else if (mSyst.ToLower() == "celsius" || mSyst.ToLower() == "c")
            {
                a = (tempD * 9 / 5) + 32;
                b = (tempD + 273.15);
                answer = "To Fahrenheit: " + a + " To Kelvin: " + b;
            }
            else if (mSyst.ToLower() == "kelvin" || mSyst.ToLower() == "k")
            {
                a = (tempD - 273.15) * 1.8 + 32;
                b = (tempD - 273.15);
                answer = "To Fahrenheit: " + a + " To Celsius: " + b;
            }

            ViewBag.Message = answer;
            return View();
        }

        //GET: Page2
        [HttpGet]
        public ActionResult Page2()
        {
            return View();
        }

        //The post for page2.
        [HttpPost]
        public ActionResult Page2(FormCollection form)
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