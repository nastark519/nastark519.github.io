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
        //make the database to be used. Its name will be db.

        private DMVContext db = new DMVContext();

        //Home page landing
        public ActionResult Index()
        {
            return View();
        }

        /*Brings up the page of the form.*/
        [HttpGet]
        public ActionResult Page1()
        {
            return View();
        }

        /*Posts for a change to the form.*/
        [HttpPost]
        public ActionResult Page1([Bind(Include ="ID, DateOfBirth, NewAddress, County, FullName, City, NewState, Zip, SignDate")]DmvStuff info)
        {
            if (ModelState.IsValid)
            {
                //add the new info into the database and then save this change.
                db.DmvStuffs.Add(info);
                db.SaveChanges();
                //Send user back to landing page when done.
                return RedirectToAction("Index");
            }
            //otherwise stay at this view enorder to make the nessesery changes.
            return View();
        }

        public ActionResult Page2()
        {
            return View(db.DmvStuffs.ToList());
        }
    }
}